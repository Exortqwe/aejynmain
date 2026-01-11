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
using aejynmain.Models;

namespace aejynmain
{
    public partial class MainForm : Form
    {
        UC_Dashboard dashboard = new UC_Dashboard();
        UC_Rentals reservations = new UC_Rentals();
        UC_Customers customers = new UC_Customers();
        UC_Returns returns = new UC_Returns();
        UC_Reports reports = new UC_Reports();
        UC_Reservations reservation = new UC_Reservations();
        UC_Maintenance maintenance = new UC_Maintenance();
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
        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {       

            if (UserSession.IsRentalAgent)
            {
                btnDashboard.Visible = false;
                btnUserManagement.Visible = false;
                btnReports.Visible = false;

                LoadUserControl(new UC_Customers());
            }
            else if (UserSession.IsAdmin)
            {
                LoadUserControl(new UC_Dashboard());
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard = new UC_Dashboard();
            addUserControls(dashboard);
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            UC_Rentals reservations = new UC_Rentals();
            addUserControls(reservations);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Customers());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Clear the user session
            UserSession.ClearSession();

            // Show login form
            frmLogIn login = new frmLogIn();
            login.Show();

            // Close the main form
            this.Close();
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

        private void btnReservation_Click(object sender, EventArgs e)
        {
            UC_Reservations reservation = new UC_Reservations();
            addUserControls(reservation);
        }
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            UC_Maintenance maintenance = new UC_Maintenance();
            addUserControls(maintenance);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UC_UserManagement umanagement = new UC_UserManagement();
            addUserControls(umanagement);
        }

        private void UCHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
