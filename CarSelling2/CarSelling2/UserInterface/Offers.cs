using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarSelling2.Classes;

namespace CarSelling2.UserInterface
{
    public partial class Offers : UserControl
    {
        public Offers()
        {
            InitializeComponent();
        }

        private void Offers_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = DataManager.GetAllOffers();
            gridControl1.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DataManager.GetAllOffers();
            gridControl1.Refresh();
        }

        public int SelectedCarId;
        private void layoutView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != null)
            {
                CarsInfo selectedCarsInfo = (CarsInfo) layoutView1.GetRow(e.FocusedRowHandle);
                SelectedCarId = selectedCarsInfo.Id;
                gridControl2.DataSource = DataManager.GetSelectedCarsFotos(SelectedCarId);
                gridControl2.Refresh();
                List<Ownerinfo> ownerinfos = new List<Ownerinfo>();
                ownerinfos.Add(DataManager.GetSelectedCarsoOwnerinfo(SelectedCarId));
                gridControl3.DataSource = ownerinfos;
                gridControl3.Refresh();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataManager.UpdateData(SelectedCarId);
            gridControl1.DataSource = DataManager.GetAllOffers();
            gridControl1.Refresh();
            gridControl2.Refresh();
            gridControl3.Refresh();
            MessageBox.Show("Car is Soled");

        }
    }
}
