using System;
using System.Windows.Forms;
using aejynmain.AuthManager;

namespace aejynmain.UserControls
{
    public partial class UC_Reports : UserControl
    {
        private readonly ReportManager _reportManager;

        public UC_Reports()
        {
            InitializeComponent();
            _reportManager = new ReportManager();
            LoadPerformanceMetrics();
        }

        private void LoadPerformanceMetrics()
        {
            try
            {
                // Load and display metrics
                LoadFleetUtilizationRate();
                LoadRevenuePerVehicle();
                LoadAverageRentalRate();
                LoadFleetAvailabilityStatus();
                LoadPopularVehicles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading performance metrics: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFleetUtilizationRate()
        {
            var (utilizationRate, totalRentalDays, totalAvailableDays) = _reportManager.GetFleetUtilizationRate();
            lblFleetRate.Text = $"{utilizationRate:F2}%";
        }

        private void LoadRevenuePerVehicle()
        {
            decimal revenuePerVehicle = _reportManager.GetRevenuePerVehicle();
            lblRevenuePerVehicle.Text = $"₱{revenuePerVehicle:N2}";
        }

        private void LoadAverageRentalRate()
        {
            decimal avgRate = _reportManager.GetAverageRentalRate();
            lblAverageRentalRate.Text = $"₱{avgRate:N2}";
        }

        private void LoadFleetAvailabilityStatus()
        {
            try
            {
                var statusData = _reportManager.GetVehicleAvailabilityStatus();

                // Clear existing data
                dgFleetAvailabilityStatus.Rows.Clear();
                dgFleetAvailabilityStatus.Columns.Clear();

                // Add columns
                dgFleetAvailabilityStatus.Columns.Add("Category", "Category");
                dgFleetAvailabilityStatus.Columns.Add("Available", "Available");
                dgFleetAvailabilityStatus.Columns.Add("Rented", "Rented");
                dgFleetAvailabilityStatus.Columns.Add("Maintenance", "Maintenance");
                dgFleetAvailabilityStatus.Columns.Add("Total", "Total");

                // Center align all columns
                foreach (DataGridViewColumn column in dgFleetAvailabilityStatus.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                // Add data rows, excluding the 'Total' row
                foreach (System.Data.DataRow row in statusData.Rows)
                {
                    string category = row["Category"].ToString();
                    if (category.Equals("Total", StringComparison.OrdinalIgnoreCase))
                        continue;

                    dgFleetAvailabilityStatus.Rows.Add(
                        category,
                        row["Available"],
                        row["Rented"],
                        row["Maintenance"],
                        row["Total"]
                    );
                }

                // Style the DataGridView
                dgFleetAvailabilityStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgFleetAvailabilityStatus.AllowUserToAddRows = false;
                dgFleetAvailabilityStatus.RowHeadersVisible = false;
                dgFleetAvailabilityStatus.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading fleet status: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPopularVehicles()
        {
            try
            {
                var popularVehicles = _reportManager.GetPopularVehicles();

                // Clear existing data and columns
                dgPopularVehicles.Rows.Clear();
                dgPopularVehicles.Columns.Clear();

                // Add columns
                dgPopularVehicles.Columns.Add("Model", "Vehicle Model");
                dgPopularVehicles.Columns.Add("Category", "Category");
                dgPopularVehicles.Columns.Add("RentalCount", "Times Rented");
                dgPopularVehicles.Columns.Add("RentalPercentage", "Popularity %");

                // Format columns
                dgPopularVehicles.Columns["RentalPercentage"].DefaultCellStyle.Format = "0.00'%'";
                dgPopularVehicles.Columns["RentalCount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgPopularVehicles.Columns["RentalPercentage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Add data rows
                foreach (System.Data.DataRow row in popularVehicles.Rows)
                {
                    dgPopularVehicles.Rows.Add(
                        row["Model"],
                        row["Category"],
                        row["RentalCount"],
                        row["RentalPercentage"]
                    );
                }

                // Style the DataGridView
                dgPopularVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgPopularVehicles.AllowUserToAddRows = false;
                dgPopularVehicles.RowHeadersVisible = false;
                dgPopularVehicles.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading popular vehicles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        

