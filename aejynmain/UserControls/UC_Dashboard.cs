using aejynmain.AuthManager;
using aejynmain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aejynmain.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
            LoadUser();
        }
        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
        }
        private void LoadDashboardData()
        {
            try
            {
                // Tawag sa service para makuha ang data
                var dashboardData = DashboardService.GetDashboardData();

                // mga panel cards
                lblTotalVehicles.Text = dashboardData.TotalVehicles.ToString();
                lblAvailableVehicles.Text = dashboardData.AvailableVehicles.ToString();
                lblActiveRentals.Text = dashboardData.ActiveRentals.ToString();
                lblReservedVehicles.Text = dashboardData.Reservation.ToString();
                lblLateReturn.Text = dashboardData.LateReturn.ToString();
                lblRevenueToday.Text = dashboardData.RevenueToday.ToString("₱#,###.00");

                // Charts
                DataTable dtRevenue = DashboardService.RevenueByDate(); // declare ug assign
                chartRevenue.Series[0].Points.Clear();
                foreach (DataRow row in dtRevenue.Rows)
                {
                    chartRevenue.Series[0].Points.AddXY(
                        Convert.ToDateTime(row["payDate"]).ToString("MM dd"),
                        Convert.ToDecimal(row["totalRevenue"]));
                }

                DataTable dtVehicle = DashboardService.VehicleStatus(); // declare ug assign
                chartVehicleStatus.Series[0].Points.Clear();
                foreach (DataRow row in dtVehicle.Rows)
                {
                    chartVehicleStatus.Series[0].Points.AddXY(
                        row["VehicleStatus"].ToString(),
                        Convert.ToInt32(row["total"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chartRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}