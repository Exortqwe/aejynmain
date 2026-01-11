using aejynmain.AuthManager;
using aejynmain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
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
                var dashboardData = DashboardService.GetDashboardData();

                // Panel cards
                lblTotalVehicles.Text = dashboardData.TotalVehicles.ToString();
                lblAvailableVehicles.Text = dashboardData.AvailableVehicles.ToString();
                lblActiveRentals.Text = dashboardData.ActiveRentals.ToString();
                lblReservedVehicles.Text = dashboardData.Reservation.ToString();
                lblOverdue.Text = dashboardData.Overdue.ToString();
                lblOverdue.Visible = dashboardData.Overdue > 0;
                lblRevenueToday.Text = dashboardData.RevenueToday.ToString("₱#,###.00");

                // -------------------- Revenue chart --------------------
                DataTable dtRevenue = DashboardService.RevenueByDate();
                chartRevenue.Series[0].Points.Clear();

                foreach (DataRow row in dtRevenue.Rows)
                {
                    DateTime payDate = Convert.ToDateTime(row["payDate"]);
                    decimal revenue = Convert.ToDecimal(row["totalRevenue"]);

                    // Add X=Date, Y=Revenue
                    chartRevenue.Series[0].Points.AddXY(payDate, revenue);
                }

                // Format X-axis for better readability
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd"; // show month-day
                chartRevenue.ChartAreas[0].AxisX.Interval = 1;                 // interval 1 day
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -45;      // tilt labels
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8);

                // -------------------- Vehicle status chart --------------------
                DataTable dtVehicle = DashboardService.VehicleStatus();
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
            // Optional: handle clicks on the revenue chart if needed
        }
    }
}

