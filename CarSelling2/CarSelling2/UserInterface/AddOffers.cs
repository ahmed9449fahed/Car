using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CarSelling2.Classes;

namespace CarSelling2.UserInterface
{
    public partial class AddOffers : UserControl
    {
        public AddOffers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CarsInfo car = new CarsInfo
            {
                Modell = textBoxModell.Text,
                Status = textBoxStatus.Text,
                Price = Convert.ToDouble(textBoxPrice.Text),
                Adress = textBoxAdress.Text,
                Insurance = dateTimePickerInsurance.Value,
                Sold = false
            };
            
            Ownerinfo owner = new Ownerinfo
            {
                Vorname = textBoxFirstName.Text,
                Nachname = textBoxLastName.Text,
                Telephonenumber = textBoxTelephoneNumber.Text,
                Emailadress = textBoxEmailAdress.Text
            };
            DataManager.AddNewOffer(car, Foto, owner);
            Clearall();
            MessageBox.Show("success");
            
        }

        public void Clearall()
        {
            textBoxModell.Clear();
            textBoxAdress.Clear();
            textBoxTelephoneNumber.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPrice.Clear();   
            textBoxStatus.Clear();
            textBoxEmailAdress.Clear();
            Foto.Clear();
            gridControl1.DataSource = Foto;
            gridControl1.Refresh();
        }
        public MemoryStream Ms = new MemoryStream();
        public List<CarsFoto> Foto = new List<CarsFoto>();
        private void btnSelectFotos_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.ShowDialog();
            string [] result = open.FileNames;
            foreach (var path in result)
            {
                Image img = Image.FromFile(path);
                Ms = new MemoryStream();
                img.Save(Ms, img.RawFormat);
                CarsFoto f = new CarsFoto
                {
                    Foto = Ms.ToArray()
                };
                Foto.Add(f);
            }
            

            gridControl1.DataSource = Foto;
            gridControl1.Refresh();

        }
    }
}
