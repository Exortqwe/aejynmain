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
            LoadActiveRentalsGrid();
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
                lblUnderMaintenance.Text = dashboardData.UnderMaintenance.ToString();

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
                chartArea.AxisX.LabelStyle.Enabled = false;
                chartArea.AxisY.LabelStyle.Enabled = false;
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = false;

                // Add data points, skip zero counts
                foreach (DataRow row in dtVehicle.Rows)
                {
                    string status = row["VehicleStatus"].ToString();
                    int count = Convert.ToInt32(row["total"]);

                    if (count == 0) continue; // Skip zero-count slices

                    // Add the point and set its legend text
                    DataPoint point = series.Points.Add(count);
                    point.LegendText = status;
                    point.Label = "#PERCENT{P0}";  // Show percentage
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadActiveRentalsGrid()
        {
            try
            {
                DataTable dt = DashboardService.GetActiveRentalsDashboard();
                dgActiveRentals.DataSource = dt;

                // Optional: reorder columns
                if (dgActiveRentals.Columns.Contains("RentalID")) dgActiveRentals.Columns["RentalID"].DisplayIndex = 0;
                if (dgActiveRentals.Columns.Contains("CustomerName")) dgActiveRentals.Columns["CustomerName"].DisplayIndex = 1;
                if (dgActiveRentals.Columns.Contains("Vehicle")) dgActiveRentals.Columns["Vehicle"].DisplayIndex = 2;

                // Format dates
                if (dgActiveRentals.Columns.Contains("PickUpDate"))
                    dgActiveRentals.Columns["PickUpDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                if (dgActiveRentals.Columns.Contains("ReturnDate"))
                    dgActiveRentals.Columns["ReturnDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading active rentals: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

