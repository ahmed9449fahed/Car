using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Runtime.CompilerServices;
using Microsoft.Win32;
using SellingCar_WPF.Annotations;
using SellingCar_WPF.Classes;

namespace SellingCar_WPF
{
    //[POCOViewModel]
    //public class MainWindowViewModel : INotifyPropertyChanged
    //{
    //public event PropertyChangedEventHandler PropertyChanged;

    //protected virtual void RaisePropertyChanged(string propertyName)
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}

    //private string _sample;

    // View {Binding Sample}
    //public string Sample
    //{
    //    get { return _sample; }
    //    set
    //    {
    //        if (Equals(_sample, value))
    //            return;
    //        _sample = value;
    //        RaisePropertyChanged(nameof(Sample));
    //    }
    //}

    //    public IEnumerable<object> Grid2Fotos { get; set; }

    //    public IEnumerable<CarsFoto> CarsFotos { get; } = new[] { new CarsFoto(), new CarsFoto() };

    // CarsFoto -> Model


    // Wpf or WinForms   Control-Framework
    // MVVM Model View ViewModel -> Design Pattern or MVC Model View Controller or MVP Model View Presenter
    // Helper-Classes -> POCOViewModel 

    // HALOS/Triple7Manager Wpf (DevExpress-Controls) & MVVM 
    //


    //}

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //public class MainWindowViewModel
    //{
    //    public List<CarsInfo> CarsInfos { get; set; }

    //    public List<CarsFoto> CarsFotos { get; set; }

    //}
    //[POCOViewModel]
    public partial class MainWindow : INotifyPropertyChanged // View
    {
        public MainWindow()
        {
            DataContext = this;

            InitializeComponent();
        }

        public List<CarsFoto> CarsFotos = new List<CarsFoto>();

        public List<CarsInfo> carsInfo;


        public List<CarsInfo> CarsInfo
        {
            set
            {
                if (Equals(carsInfo, value))
                    return;
                carsInfo = value;
                OnPropertyChanged(nameof(CarsInfo));
            }
            get
            {
                return carsInfo;
            }

        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {

            CarsInfo car = new CarsInfo
            {
                Modell = TxtModel.Text,
                Status = TxtStatus.Text,
                Price = Convert.ToDouble(TxtPrice.Text),
                Adress = TxtAdress.Text,
                Insurance = DatepickerInsurance.DisplayDate,
                Sold = false
            };

            Ownerinfo owner = new Ownerinfo
            {
                Vorname = TxtFirstName.Text,
                Nachname = TxtLastName.Text,
                Telephonenumber = TxtTelefoneNumber.Text,
                Emailadress = TxtEmailAdress.Text
            };
            DataManager.AddNewOffer(car, CarsFotos, owner);
            CarsInfo = DataManager.GetAllOffers();


        }

        MemoryStream _ms = new MemoryStream();

        private void BtnOpenImage_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.ShowDialog();
            string[] pathes = open.FileNames;
            foreach (var path in pathes)
            {
                Image img = Image.FromFile(path);
                _ms = new MemoryStream();
                img.Save(_ms, img.RawFormat);
                CarsFoto f = new CarsFoto
                {
                    Foto = _ms.ToArray()
                };
                CarsFotos.Add(f);
            }

            Test.ItemsSource = CarsFotos;
            Test.RefreshData();
        }
        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            carsInfo = DataManager.GetAllOffers();
            GridCarinfo.ItemsSource = carsInfo;
            GridCarinfo.RefreshData();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            GridCarinfo.ItemsSource = carsInfo;
            GridCarinfo.RefreshData();
        }
    }
}
