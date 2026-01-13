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
        // Constructor: initialize component and load dashboard info
        public UC_Dashboard()
        {
            InitializeComponent();  // Initialize UI controls
            LoadDashboardData();    // Load charts and stats
            LoadUser();             // Show current logged-in user info
            LoadActiveRentalsGrid();// Load active rentals in datagrid
        }

        //  User Info 
        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username; // Show current username
            lblRole.Text = UserSession.Role;         // Show user role
        }

        //  Dashboard Stats 
        private void LoadDashboardData()
        {
            try
            {
                var dashboardData = DashboardService.GetDashboardData(); // Fetch dashboard numbers (SRP: DashboardService handles data)

                // Panel cards - show counts on dashboard (OOP: encapsulation of data in DashboardData)
                lblTotalVehicles.Text = dashboardData.TotalVehicles.ToString();
                lblAvailableVehicles.Text = dashboardData.AvailableVehicles.ToString();
                lblActiveRentals.Text = dashboardData.ActiveRentals.ToString();
                lblReservedVehicles.Text = dashboardData.Reservation.ToString();
                lblOverdue.Text = dashboardData.Overdue.ToString();
                lblOverdue.Visible = dashboardData.Overdue > 0;          // Show only if > 0
                lblRevenueToday.Text = dashboardData.RevenueToday.ToString("₱#,###.00");
                lblUnderMaintenance.Text = dashboardData.UnderMaintenance.ToString();

                //  Revenue Chart 
                DataTable dtRevenue = DashboardService.RevenueByDate(); // Get revenue for last 7 days
                var revenueSeries = chartRevenue.Series[0];
                revenueSeries.Points.Clear();
                revenueSeries.Name = "Revenue in Last 7 Days";          // Set chart series name

                chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "₱#,##0"; // Format Y-axis with peso sign

                foreach (DataRow row in dtRevenue.Rows)
                {
                    DateTime payDate = Convert.ToDateTime(row["payDate"]);
                    decimal revenue = Convert.ToDecimal(row["totalRevenue"]);
                    revenueSeries.Points.AddXY(payDate, revenue); // Add point to chart
                }

                // Format X-axis
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd";
                chartRevenue.ChartAreas[0].AxisX.Interval = 1;
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -45;   // Tilt labels
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8);

                // Y-axis title
                chartRevenue.ChartAreas[0].AxisY.Title = "Amount (₱)";
                chartRevenue.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 9, FontStyle.Bold);

                //  Vehicle Status Pie Chart 
                DataTable dtVehicle = DashboardService.VehicleStatus(); // Get vehicle counts by status
                chartVehicleStatus.Series[0].Points.Clear();
                var series = chartVehicleStatus.Series[0];
                series.ChartType = SeriesChartType.Pie; // Pie chart
                series.LabelForeColor = Color.White;
                series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                series.IsValueShownAsLabel = true;

                // Legend settings
                var legend = chartVehicleStatus.Legends[0];
                legend.Enabled = true;
                legend.Docking = Docking.Right;
                legend.Title = "Vehicle Status";
                legend.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

                // Chart area settings
                var chartArea = chartVehicleStatus.ChartAreas[0];
                chartArea.AxisX.LabelStyle.Enabled = false;
                chartArea.AxisY.LabelStyle.Enabled = false;
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = false;

                // Add data points (skip zero-counts)
                foreach (DataRow row in dtVehicle.Rows)
                {
                    string status = row["VehicleStatus"].ToString();
                    int count = Convert.ToInt32(row["total"]);
                    if (count == 0) continue;

                    DataPoint point = series.Points.Add(count);
                    point.LegendText = status;
                    point.Label = "#PERCENT{P0}"; // Show percentage
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Active Rentals Grid 
        private void LoadActiveRentalsGrid()
        {
            try
            {
                DataTable dt = DashboardService.GetActiveRentalsDashboard(); // Get active rentals data
                dgActiveRentals.DataSource = dt; // Bind to datagrid

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


