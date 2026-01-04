using aejynmain.Models;
using aejynmain.StaffUserControls;
using aejynmain.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aejynmain.StaffWinforms
{
    public partial class StaffMainForm : Form
    {
        UC_StaffCustomers sc = new UC_StaffCustomers();
        public StaffMainForm()
        {
            InitializeComponent();
            addUserControls(sc);
        }
        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            staffpanel.Controls.Clear();
            staffpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            UC_StaffCustomers sc = new UC_StaffCustomers();
            addUserControls(sc);

        }



        private void btnVehicleFleet_Click(object sender, EventArgs e)
        {

            UC_StaffVehicleReturn sv = new UC_StaffVehicleReturn();
            addUserControls(sv);

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

            UC_StaffReservations usr = new UC_StaffReservations();
            addUserControls(usr);

        }

        private void btnReturns_Click(object sender, EventArgs e)
        {

            UC_StaffVehicleReturn svr = new UC_StaffVehicleReturn();
            addUserControls(svr);

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {

            UC_StaffMaintenance sm = new UC_StaffMaintenance();
            addUserControls(sm);

        }
        private void btnRentals_Click(object sender, EventArgs e)
        {
            UC_StaffRentals srent = new UC_StaffRentals();
            addUserControls(srent);

        }
    }
}
