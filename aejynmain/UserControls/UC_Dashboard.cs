using aejynmain.AuthManager;
using aejynmain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
                var revenueSeries = chartRevenue.Series[0];
                revenueSeries.Points.Clear();
                revenueSeries.Name = "Revenue in Last 7 Days";  // Set the series name

                // Format the Y-axis to show peso sign
                chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "₱#,##0";  // Add peso sign and thousand separators

                foreach (DataRow row in dtRevenue.Rows)
                {
                    DateTime payDate = Convert.ToDateTime(row["payDate"]);
                    decimal revenue = Convert.ToDecimal(row["totalRevenue"]);

                    // Add X=Date, Y=Revenue
                    revenueSeries.Points.AddXY(payDate, revenue);
                }

                // Format X-axis for better readability
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd";  // show month-day
                chartRevenue.ChartAreas[0].AxisX.Interval = 1;                 // interval 1 day
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -45;      // tilt labels
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8);

                // Add title to the Y-axis
                chartRevenue.ChartAreas[0].AxisY.Title = "Amount (₱)";
                chartRevenue.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 9, FontStyle.Bold);

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

                // Set up the pie chart
                var series = chartVehicleStatus.Series[0];
                series.ChartType = SeriesChartType.Pie;
                series.Label = "#PERCENT{P0}";  // Show percentage with 0 decimal places
                series.LabelForeColor = Color.White;
                series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                series.IsValueShownAsLabel = true;

                // Configure the legend
                var legend = chartVehicleStatus.Legends[0];
                legend.Enabled = true;
                legend.Docking = Docking.Right;
                legend.Title = "Vehicle Status";
                legend.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

                // Ensure the chart area is properly configured
                var chartArea = chartVehicleStatus.ChartAreas[0];
                chartArea.AxisX.LabelStyle.Enabled = false;  // Hide X-axis labels
                chartArea.AxisY.LabelStyle.Enabled = false;  // Hide Y-axis labels
                chartArea.AxisX.MajorGrid.Enabled = false;   // Hide X-axis grid
                chartArea.AxisY.MajorGrid.Enabled = false;   // Hide Y-axis grid

                // Add data points
                foreach (DataRow row in dtVehicle.Rows)
                {
                    string status = row["VehicleStatus"].ToString();
                    int count = Convert.ToInt32(row["total"]);

                    // Add the point and set its legend text
                    DataPoint point = series.Points.Add(count);
                    point.LegendText = status;
                    point.Label = "#PERCENT{P0}";  // This will show the percentage
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

