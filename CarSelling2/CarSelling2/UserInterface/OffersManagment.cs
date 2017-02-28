using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarSelling2.Classes;

namespace CarSelling2.UserInterface
{
    public partial class OffersManagment : UserControl
    {
        public OffersManagment()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DataManager.GetAllOfferswithSoledOffers();
            gridControl1.Refresh();
        }

        private void OffersManagment_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = DataManager.GetAllOfferswithSoledOffers();
            gridControl1.Refresh();

        }

        public int SelectedCarId;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (e.FocusedRowHandle != null)
            {
                CarsInfo selectedCarsInfo = (CarsInfo)gridView1.GetRow(e.FocusedRowHandle);
                SelectedCarId = selectedCarsInfo.Id;
                List<SellInfo> sellInfos=new List<SellInfo>();
                sellInfos.Clear();
                sellInfos.Add(DataManager.GetSellingInfo(SelectedCarId));
                gridControl2.DataSource = sellInfos;
                gridControl2.Refresh();
                List<Ownerinfo> ownerinfos = new List<Ownerinfo>();
                ownerinfos.Add(DataManager.GetSelectedCarsoOwnerinfo(SelectedCarId));
                gridControl3.DataSource = ownerinfos;
                gridControl3.Refresh();
            }
        }
    }
}
