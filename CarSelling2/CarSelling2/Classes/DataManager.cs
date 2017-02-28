using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using CarSelling2.DatenBank;
using DevExpress.Data.WcfLinq.Helpers;
using DevExpress.Xpo.Helpers;
using DevExpress.XtraScheduler.Native;

namespace CarSelling2.Classes
{
    public class DataManager
    {
        public static void AddNewOffer(CarsInfo car, List<CarsFoto> fotos, Ownerinfo owner)
        {
            CarsSellingEntities1 context = new CarsSellingEntities1();
            TbCarsInfo newcar = new TbCarsInfo();
            newcar.Modell = car.Modell;
            newcar.Status = car.Status;
            newcar.Insurance = car.Insurance;
            newcar.Adress = car.Adress;
            newcar.Price = car.Price;
            newcar.Sold = car.Sold;
            context.TbCarsInfoes.Add(newcar);
            context.SaveChanges();
            int id = newcar.Id;
            foreach (CarsFoto carsFoto in fotos)
            {
                TbCarsFoto newCarsFoto = new TbCarsFoto();
                newCarsFoto.CarId = id;
                newCarsFoto.Foto = carsFoto.Foto;
                context.TbCarsFotoes.Add(newCarsFoto);
                context.SaveChanges();
            }
            TbOwnersInfo newowner = new TbOwnersInfo();
            newowner.Vorname = owner.Vorname;
            newowner.nachname = owner.Nachname;
            byte[] telephonenumber = Encoding.ASCII.GetBytes(owner.Telephonenumber);

            newowner.TelephoneNumber =telephonenumber;
            newowner.EmailAdress = owner.Emailadress;
            newowner.CarId = id;

            context.TbOwnersInfoes.Add(newowner);
            context.SaveChanges();

        }


        public static List<CarsInfo> GetAllOffers()
        {
            List<CarsInfo> infos = new List<CarsInfo>();
            CarsSellingEntities1 context = new CarsSellingEntities1();
            foreach (TbCarsInfo info in context.TbCarsInfoes)
            {
                if (!info.Sold.Value)
                {
                    CarsInfo car = new CarsInfo();
                    car.Modell = info.Modell;
                    car.Adress = info.Adress;
                    car.Status = info.Status;
                    car.Price = Convert.ToDouble(info.Price);
                    car.Insurance = Convert.ToDateTime(info.Insurance);
                    car.Id = info.Id;

                    foreach (TbCarsFoto foto in context.TbCarsFotoes)
                    {
                        if (foto.CarId == info.Id)
                        {
                            car.DisplayFoto = foto.Foto;
                            break;
                        }
                    }
                    infos.Add(car);
                }
            }
            return infos;
        }
        public static List<CarsInfo> GetAllOfferswithSoledOffers()
        {
            List<CarsInfo> infos = new List<CarsInfo>();
            CarsSellingEntities1 context = new CarsSellingEntities1();
            foreach (TbCarsInfo info in context.TbCarsInfoes)
            {
               
                    CarsInfo car = new CarsInfo();
                    car.Modell = info.Modell;
                    car.Adress = info.Adress;
                    car.Status = info.Status;
                    car.Price = Convert.ToDouble(info.Price);
                    car.Insurance = Convert.ToDateTime(info.Insurance);
                    car.Id = info.Id;
                    car.Sold = info.Sold.Value;

                    foreach (TbCarsFoto foto in context.TbCarsFotoes)
                    {
                        if (foto.CarId == info.Id)
                        {
                            car.DisplayFoto = foto.Foto;
                            break;
                        }
                    }
                    infos.Add(car);
                }
            
            return infos;
        }

        public static List<CarsFoto> GetSelectedCarsFotos(int carId)
        {
            List<CarsFoto> fotos = new List<CarsFoto>();
            CarsSellingEntities1 context = new CarsSellingEntities1();
            foreach (TbCarsFoto carsFoto in context.TbCarsFotoes)
            {
                if (carsFoto.CarId == carId)
                {
                    CarsFoto foto=new CarsFoto();
                    foto.Foto = carsFoto.Foto;
                    fotos.Add(foto);
                }
                    
            }
            return fotos;
        }

        public static Ownerinfo GetSelectedCarsoOwnerinfo(int carId)
        {
            Ownerinfo infOwnerinfo=new Ownerinfo();
            CarsSellingEntities1 context = new CarsSellingEntities1();
            foreach (TbOwnersInfo info in context.TbOwnersInfoes)
            {
                if (info.TbCarsInfo.Id==carId)
                {
                    infOwnerinfo.Vorname = info.Vorname;
                    infOwnerinfo.Nachname = info.nachname;
                    string value = Encoding.ASCII.GetString(info.TelephoneNumber);
                    infOwnerinfo.Telephonenumber = value;
                    infOwnerinfo.Emailadress = info.EmailAdress;
                }
            }
            return infOwnerinfo;
        }
        public static List<SellingDateTime> GetAllSellingTime()
        {
            List<SellingDateTime> sellingtime=new List<SellingDateTime>();
            CarsSellingEntities1 context = new CarsSellingEntities1();
            foreach (TbSellingInfo info in context.TbSellingInfoes)
            {
                SellingDateTime appointment = new SellingDateTime();
                foreach (TbCarsInfo carsInfo in context.TbCarsInfoes)
                {
                    if (carsInfo.Id == info.CarId)
                    {
                        appointment.Name = carsInfo.Modell;
                        break;
                    }
                }
                
                appointment.Dtime = Convert.ToDateTime(info.SellingDate);
                sellingtime.Add(appointment);
            }
            return sellingtime;
        }
        public static SellInfo GetSellingInfo(int carId)
        {
            SellInfo sellInfo = new SellInfo();
            CarsSellingEntities1 context = new CarsSellingEntities1();
            foreach (TbSellingInfo info in context.TbSellingInfoes)
            {
                if (info.CarId == carId)
                {
                    sellInfo.Price = Convert.ToDouble(info.SellingPrice);
                    if (info.SellingDate != null) sellInfo.SellingDate = info.SellingDate.Value;
                    if (info.Profit != null) sellInfo.Profit = info.Profit.Value;
                }
            }
            return sellInfo;
        }
        public static void UpdateData(int carId)
        {
            CarsSellingEntities1 context=new CarsSellingEntities1();
            foreach (TbCarsInfo carsInfo in context.TbCarsInfoes)
            {
                if (carsInfo.Id == carId)
                {
                    carsInfo.Sold = true;
                    context.TbCarsInfoes.AddOrUpdate(carsInfo);
                    TbSellingInfo sellinfo = new TbSellingInfo();
                    sellinfo.CarId = carId;
                    sellinfo.SellingPrice = carsInfo.Price;
                    sellinfo.Profit = 5 * carsInfo.Price / 100;
                    sellinfo.SellingDate=DateTime.Now;
                    context.TbSellingInfoes.AddOrUpdate(sellinfo);
                    break;
                }
            }
           
            context.SaveChanges();

        }
    }
}
