using aejynmain.AuthManager;
using aejynmain.HelperMethod;
using aejynmain.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace aejynmain.UserControls
{
    public partial class UC_Rentals : UserControl
    {
        private decimal hourlyRate;
        private decimal dailyRate;
        private decimal weeklyRate;
        private decimal monthlyRate;

        private int selectedCustomerId = 0;
        private int selectedVehicleId = 0;
        private decimal computedTotal = 0;

        public UC_Rentals()
        {
            InitializeComponent();
            LoadAvailableVehicles();
            UpdateSummaryDates();
            LoadUser();
        }
        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
        }

        private void EnsureVehicleFleetColumns(DataGridView dg)
        {
            if (dg == null) return;

            // Only configure once
            if (!dg.AutoGenerateColumns && dg.Columns.Count > 0) return;

            dg.AutoGenerateColumns = false;
            dg.Columns.Clear();

            void Add(string name, string header)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = name,
                    Name = name,
                    HeaderText = header,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dg.Columns.Add(col);
            }

            // Match Vehicle Fleet order
            Add("VehicleID", "VehicleID");
            Add("CategoryName", "CategoryName");
            Add("Make", "Make");
            Add("Model", "Model");
            Add("LicensePlate", "LicensePlate");
            Add("Mileage", "Mileage");
            Add("Year", "VehicleYear");
            Add("VIN", "VIN");
            Add("Color", "Color");
            Add("Transmission", "Transmission");
            Add("FuelType", "FuelType");
            Add("InitialCondition", "InitialCondition");
            Add("SeatingCapacity", "SeatingCapacity");
            Add("FuelLevel", "FuelLevel");
            Add("HourlyRate", "HourlyRate");
            Add("DailyRate", "DailyRate");
            Add("WeeklyRate", "WeeklyRate");
            Add("MonthlyRate", "MonthlyRate");
            Add("Status", "Status");
            Add("Features", "Features");
            Add("image_path", "image_path");

            // Format currency columns if they exist
            if (dg.Columns["HourlyRate"] != null) dg.Columns["HourlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            if (dg.Columns["DailyRate"] != null) dg.Columns["DailyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            if (dg.Columns["WeeklyRate"] != null) dg.Columns["WeeklyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            if (dg.Columns["MonthlyRate"] != null) dg.Columns["MonthlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
        }

        // ================= CUSTOMER SEARCH =================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dt = CustomerDetails.GetCustomers();
            string search = txtSearch.Text.Trim();

            selectedCustomerId = 0;

            foreach (System.Data.DataRow row in dt.Rows)
            {
                string firstName = row["FirstName"].ToString();
                string lastName = row["LastName"].ToString();
                string fullName = $"{firstName} {lastName}";

                if (fullName.Contains(search) || row["LicenseNumber"].ToString().Contains(search))
                {
                    selectedCustomerId = Convert.ToInt32(row["CustomerID"]);

                    lblFullName.Text = fullName;
                    lblLicenseNumber.Text = row["LicenseNumber"].ToString();
                    lblContactNumber.Text = row["ContactNumber"].ToString();
                    lblAddress.Text = row["Address"].ToString();
                    return;
                }
            }

            MessageBox.Show("Customer not found.");
            lblFullName.Text = "";
            lblLicenseNumber.Text = "";
            lblContactNumber.Text = "";
            lblAddress.Text = "";
        }

        // ================= LOAD VEHICLES =================
        private void LoadAvailableVehicles()
        {
            EnsureVehicleFleetColumns(dgAvailableVehicles);
            dgAvailableVehicles.DataSource = RentalManager.GetAvailableVehicles();

            if (dgAvailableVehicles.Columns["HourlyRate"] != null)
                dgAvailableVehicles.Columns["HourlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            if (dgAvailableVehicles.Columns["DailyRate"] != null)
                dgAvailableVehicles.Columns["DailyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            if (dgAvailableVehicles.Columns["WeeklyRate"] != null)
                dgAvailableVehicles.Columns["WeeklyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            if (dgAvailableVehicles.Columns["MonthlyRate"] != null)
                dgAvailableVehicles.Columns["MonthlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
        }

        // ================= SELECT VEHICLE =================
        private void dgAvailableVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgAvailableVehicles.Rows[e.RowIndex];

            selectedVehicleId = Convert.ToInt32(row.Cells["VehicleID"].Value);
            hourlyRate = Convert.ToDecimal(row.Cells["HourlyRate"].Value);
            dailyRate = Convert.ToDecimal(row.Cells["DailyRate"].Value);
            weeklyRate = Convert.ToDecimal(row.Cells["WeeklyRate"].Value);
            monthlyRate = Convert.ToDecimal(row.Cells["MonthlyRate"].Value);

            // Display vehicle Make + Model
            string make = row.Cells["Make"].Value?.ToString() ?? "";
            string model = row.Cells["Model"].Value?.ToString() ?? "";
            lblVehicle.Text = $"{make} {model}".Trim();

            ComputeTotal();
        }

        // ================= DATE + TIME HELPERS =================
        private DateTime GetPickupDateTime()
        {
            return dtpPickUpDate.Value.Date
                .Add(dtpPickupTime.Value.TimeOfDay);
        }

        private DateTime GetReturnDateTime()
        {
            return dtpReturnDate.Value.Date
                .Add(dtpReturnTime.Value.TimeOfDay);
        }

        // ================= PRICE COMPUTATION (USING CALCULATOR) =================
        private void ComputeTotal()
        {
            if (selectedVehicleId == 0) return;

            DateTime pickup = GetPickupDateTime();
            DateTime ret = GetReturnDateTime();

            computedTotal = RentalCalculator.CalculateTotal(
                pickup,
                ret,
                hourlyRate,
                dailyRate,
                weeklyRate,
                monthlyRate,
                out string rateLabel,
                out string durationLabel
            );

            lblRate.Text = rateLabel;
            lblDays.Text = durationLabel;
            lblTotalPrice.Text = computedTotal.ToString("₱#,##0.00");

            UpdateSummaryDates();
        }

        private void UpdateSummaryDates()
        {
            lblDates.Text =
                $"{GetPickupDateTime():MM/dd/yyyy hh:mm tt} - {GetReturnDateTime():MM/dd/yyyy hh:mm tt}";
        }

        // ================= DATE/TIME EVENTS =================
        private void dtpPickUpDate_ValueChanged(object sender, EventArgs e) => ComputeTotal();
        private void dtpReturnDate_ValueChanged(object sender, EventArgs e) => ComputeTotal();
        private void dtpPickupTime_ValueChanged(object sender, EventArgs e) => ComputeTotal();
        private void dtpReturnTime_ValueChanged(object sender, EventArgs e) => ComputeTotal();

        // ================= CONFIRM RENTAL =================
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomerId == 0 || selectedVehicleId == 0)
                {
                    MessageBox.Show("Please select a customer and a vehicle.");
                    return;
                }

                if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid payment amount.");
                    return;
                }
                // Get pickup mileage gikan sa selected vehicle sa datagridview
                int pickupMileage = Convert.ToInt32(dgAvailableVehicles.CurrentRow.Cells["Mileage"].Value);
                Rental rental = new Rental
                {
                    UserID = User.UserID,
                    CustomerID = selectedCustomerId,
                    VehicleID = selectedVehicleId,
                    PickUpDate = GetPickupDateTime(),
                    ReturnDate = GetReturnDateTime(),
                    PickupMileage = pickupMileage,
                    Status = "Rented",
                    TotalAmount = computedTotal,
                    Payment = new Payment
                    {
                        PaymentType = cmbPaymentType.Text,
                        Amount = amount,
                        PaymentMethod = cmbPaymentMethod.Text,
                        PaymentStatus = cmbPaymentStatus.Text
                    }
                };

                RentalManager.SaveRental(rental);

                MessageBox.Show("Rental successfully saved!");
                LoadAvailableVehicles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }
    }
}
