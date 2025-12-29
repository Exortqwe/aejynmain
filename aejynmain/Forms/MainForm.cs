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

namespace aejynmain
{
    public partial class MainForm : Form
    {
        UC_Dashboard dashboard = new UC_Dashboard();
        UC_Rentals reservations = new UC_Rentals();
        UC_Customers customers = new UC_Customers();
        UC_Returns returns = new UC_Returns();
        UC_Reports reports = new UC_Reports();
        public MainForm()
        {
            InitializeComponent();
            addUserControls(dashboard);
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new UC_Dashboard();
            addUserControls(dashboard);
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            UC_Rentals reservations = new UC_Rentals();
            addUserControls(reservations);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            UC_Customers customers = new UC_Customers();
            addUserControls(customers);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You've been logged out successfully");
            frmLogIn login = new frmLogIn();
            login.Show();
            this.Hide();



        }

        private void btnFleetManagement_Click(object sender, EventArgs e)
        {
            UC_VehicleFleet vehiclefleet = new UC_VehicleFleet();
            addUserControls(vehiclefleet);
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            UC_Returns returns = new UC_Returns();
            addUserControls(returns);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            UC_Reports reports = new UC_Reports();
            addUserControls(reports);
        }
    }
}
