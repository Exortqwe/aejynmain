using System;
using System.Windows.Forms;
using aejynmain.AuthManager;
using aejynmain.Models;

namespace aejynmain.UserControls
{
    public partial class UC_Reports : UserControl
    {
        private readonly ReportManager _reportManager;

        public UC_Reports()
        {
            InitializeComponent();
            _reportManager = new ReportManager();

            // Hook Load event
            this.Load += UC_Reports_Load;
        }

        // 🔹 Proper Load event handler
        private void UC_Reports_Load(object sender, EventArgs e)
        {
            LoadUser();
            LoadPerformanceMetrics();
        }

        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
        }

        private void LoadPerformanceMetrics()
        {
            try
            {
                // Load main metrics
                LoadFleetUtilizationRate();
                LoadRevenuePerVehicle();
                LoadAverageRentalRate();
                LoadFleetAvailabilityStatus();
                LoadPopularVehicles();

                // 🔹 Overdue & Average Delay
                RefreshOverdueMetrics();
                lblOverdue.Text = ReportManager.GetTotalOverdueCount().ToString();
                lblAverageDelay.Text = ReportManager.GetAverageDelayHours().ToString("F2");


                LoadRentalSchedule();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading performance metrics: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshOverdueMetrics()
        {
            try
            {
                // Current overdue rentals (still active but past ReturnDate)
                int currentOverdue = ReportManager.GetTotalOverdueCount();

                // Average delay in hours for returned rentals that were late
                double avgDelayHours = ReportManager.GetAverageDelayHours();

                // Update UI labels
                lblOverdue.Text = currentOverdue.ToString("N0");
                lblOverdue.Visible = currentOverdue > 0;

                lblAverageDelay.Text = avgDelayHours.ToString("N1");
                lblAverageDelay.Visible = avgDelayHours > 0;
            }
            catch
            {
                lblOverdue.Text = "0";
                lblAverageDelay.Text = "0";
                lblOverdue.Visible = false;
                lblAverageDelay.Visible = false;
            }
        }


        // Other metric loaders (keep your existing code)
        private void LoadFleetUtilizationRate()
        {
            var (utilizationRate, _, _) = ReportManager.GetFleetUtilizationRate();
            lblFleetRate.Text = $"{utilizationRate:F2}%";
        }

        private void LoadRevenuePerVehicle()
        {
            decimal revenuePerVehicle = ReportManager.GetRevenuePerVehicle();
            lblRevenuePerVehicle.Text = $"₱{revenuePerVehicle:N2}";
        }

        private void LoadAverageRentalRate()
        {
            decimal avgRate = ReportManager.GetAverageRentalRate();
            lblAverageRentalRate.Text = $"₱{avgRate:N2}";
        }

        private void LoadFleetAvailabilityStatus()
        {
            try
            {
                var statusData = _reportManager.GetVehicleAvailabilityStatus();
                dgFleetAvailabilityStatus.Rows.Clear();
                dgFleetAvailabilityStatus.Columns.Clear();
                dgFleetAvailabilityStatus.Columns.Add("Category", "Category");
                dgFleetAvailabilityStatus.Columns.Add("Available", "Available");
                dgFleetAvailabilityStatus.Columns.Add("Rented", "Rented");
                dgFleetAvailabilityStatus.Columns.Add("Reserved", "Reserved");
                dgFleetAvailabilityStatus.Columns.Add("Maintenance", "Maintenance");
                dgFleetAvailabilityStatus.Columns.Add("Total", "Total");

                foreach (DataGridViewColumn col in dgFleetAvailabilityStatus.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                foreach (System.Data.DataRow row in statusData.Rows)
                {
                    string category = row["Category"].ToString();
                    if (category.Equals("Total", StringComparison.OrdinalIgnoreCase))
                        continue;

                    dgFleetAvailabilityStatus.Rows.Add(
                        category,
                        row["Available"],
                        row["Rented"],
                        row["Reserved"],
                        row["Maintenance"],
                        row["Total"]
                    );
                }
            }
            catch { }
        }

        private void LoadPopularVehicles()
        {
            try
            {
                var popularVehicles = _reportManager.GetPopularVehicles();

                dgPopularVehicles.Rows.Clear();
                dgPopularVehicles.Columns.Clear();
                dgPopularVehicles.Columns.Add("Model", "Vehicle Model");
                dgPopularVehicles.Columns.Add("Category", "Category");
                dgPopularVehicles.Columns.Add("RentalCount", "Times Rented");
                int percentageColIndex = dgPopularVehicles.Columns.Add("RentalPercentage", "Popularity");
                dgPopularVehicles.Columns[percentageColIndex].DefaultCellStyle.Format = "0.##'%'";
                foreach (DataGridViewColumn col in dgPopularVehicles.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                foreach (System.Data.DataRow row in popularVehicles.Rows)
                {
                    dgPopularVehicles.Rows.Add(
                        row["Model"],
                        row["Category"],
                        row["RentalCount"],
                        row["RentalPercentage"]
                    );
                }
            }
            catch { }
        }
        private void LoadRentalSchedule()
        {
            try
            {
                var rentalScheduleData = _reportManager.GetUpcomingRentalSchedule();

                dgRentalSchedDurationAnalysis.Rows.Clear();
                dgRentalSchedDurationAnalysis.Columns.Clear();

                dgRentalSchedDurationAnalysis.Columns.Add("EventStatus", "Event/Status");
                dgRentalSchedDurationAnalysis.Columns.Add("Vehicle", "Vehicle");
                dgRentalSchedDurationAnalysis.Columns.Add("Time", "Time");
                dgRentalSchedDurationAnalysis.Columns.Add("Duration", "Duration");

                foreach (DataGridViewColumn col in dgRentalSchedDurationAnalysis.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                foreach (System.Data.DataRow row in rentalScheduleData.Rows)
                {
                    dgRentalSchedDurationAnalysis.Rows.Add(
                        row["EventStatus"],
                        row["VehicleName"], // Make + Model
                        Convert.ToDateTime(row["Time"]).ToString("MMM dd, yyyy hh:mm tt"),
                        row["Duration"]
                    );
                }
            }
            catch { }
        }
    }
}

