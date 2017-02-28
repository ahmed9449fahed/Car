using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarSelling2.Classes;
using DevExpress.XtraScheduler;

namespace CarSelling2.UserInterface
{
    public partial class SellingTime : UserControl
    {
        public SellingTime()
        {
            InitializeComponent();
        }

        private void SellingTime_Load(object sender, EventArgs e)
        {
            LoadAppointment();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAppointment();
        }

        public void LoadAppointment()
        {

            schedulerControl1.ActiveViewType = SchedulerViewType.FullWeek;
            if (schedulerControl1.SelectedAppointments != null)
            {
                schedulerControl1.Storage.Appointments.Items.Clear();
            }
            List<SellingDateTime> appointments = DataManager.GetAllSellingTime();
            if (appointments != null)
            {
                foreach (SellingDateTime dt in appointments)
                {
                    schedulerControl1.Appearance.Appointment.BackColor = Color.Coral;
                    Appointment apt = schedulerControl1.Storage.CreateAppointment(AppointmentType.Normal);
                    DateTime timestart = dt.Dtime;
                    apt.Start = timestart;
                    DateTime timeend = dt.Dtime.AddMinutes(10);
                    apt.End = timeend;
                    apt.Subject = dt.Name;
                    schedulerControl1.Storage.Appointments.Add(apt);
                }
            }
        }
    }
}
