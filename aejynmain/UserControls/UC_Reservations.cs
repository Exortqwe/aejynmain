using aejynmain.AuthManager;
using aejynmain.HelperMethod;
using aejynmain.Models;
using aejynmain.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace aejynmain.UserControls
{
    public partial class UC_Reservations : UserControl
    {
        private decimal hourlyRate;
        private decimal dailyRate;
        private decimal weeklyRate;
        private decimal monthlyRate;

        private int selectedCustomerId = 0;
        private int selectedVehicleId = 0;
        private decimal computedTotal = 0;

        public UC_Reservations()
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
            if (!dg.AutoGenerateColumns && dg.Columns.Count > 0) return;

            dg.AutoGenerateColumns = false;
            dg.Columns.Clear();

            void Add(string name, string header)
            {
                dg.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = name,
                    Name = name,
                    HeaderText = header,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });
            }

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

            dg.Columns["HourlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            dg.Columns["DailyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            dg.Columns["WeeklyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            dg.Columns["MonthlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
        }

        // ================= CUSTOMER SEARCH =================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dt = CustomerDetails.GetCustomers();
            string search = txtSearch.Text.Trim();
            bool customerFound = false;

            selectedCustomerId = 0;

            // Clear previous customer info
            ClearCustomerInfo();

            foreach (DataRow row in dt.Rows)
            {
                string customerType = row["CustomerType"]?.ToString() ?? "";

                // Skip Walk-in customers
                if (customerType.Equals("WalkIn", StringComparison.OrdinalIgnoreCase))
                    continue;

                string firstName = row["FirstName"].ToString();
                string lastName = row["LastName"].ToString();
                string fullName = $"{firstName} {lastName}";
                string licenseNumber = row["LicenseNumber"].ToString();

                if (fullName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    licenseNumber.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    selectedCustomerId = Convert.ToInt32(row["CustomerID"]);

                    // MAIN DISPLAY
                    lblFullName.Text = fullName;
                    lblLicenseNumber.Text = licenseNumber;
                    lblContactNumber.Text = row["ContactNumber"].ToString();
                    lblAddress.Text = row["Address"].ToString();

                    // ====== INVOICE LABELS ======
                    lblCustomerName.Text = fullName;
                    lblLicenseNum.Text = licenseNumber;
                    lblContactNum.Text = row["ContactNumber"].ToString();
                    lblCustomerAddress.Text = row["Address"].ToString();

                    customerFound = true;
                    break; // Found a matching non-Walk-in customer
                }
            }

            if (!customerFound)
            {
                MessageBox.Show("Customer not found or is a Walk-in customer. Walk-in customers are not eligible for reservations.",
                              "Customer Not Found",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }

        private void ClearCustomerInfo()
        {
            lblFullName.Text = "";
            lblLicenseNumber.Text = "";
            lblContactNumber.Text = "";
            lblAddress.Text = "";
            selectedCustomerId = 0;

            // ====== CLEAR INVOICE LABELS ======
            lblCustomerName.Text = "";
            lblLicenseNum.Text = "";
            lblContactNum.Text = "";
            lblCustomerAddress.Text = "";
        }

        // LOAD VEHICLES
        private void LoadAvailableVehicles()
        {
            EnsureVehicleFleetColumns(dgAvailableVehicles);
            dgAvailableVehicles.DataSource = ReservationManager.GetAvailableVehicles();
        }

        // SELECT VEHICLE 
        private void dgAvailableVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgAvailableVehicles.Rows[e.RowIndex];

            selectedVehicleId = Convert.ToInt32(row.Cells["VehicleID"].Value);
            hourlyRate = Convert.ToDecimal(row.Cells["HourlyRate"].Value);
            dailyRate = Convert.ToDecimal(row.Cells["DailyRate"].Value);
            weeklyRate = Convert.ToDecimal(row.Cells["WeeklyRate"].Value);
            monthlyRate = Convert.ToDecimal(row.Cells["MonthlyRate"].Value);

            string make = row.Cells["Make"].Value.ToString();
            string model = row.Cells["Model"].Value.ToString();

            // INVOICE VEHICLE
            lblVehicle.Text = $"{make} {model}";

            ComputeTotal();
        }

        // DATE HELPERS 
        private DateTime GetPickupDateTime()
        {
            return dtpPickUpDate.Value.Date + dtpPickupTime.Value.TimeOfDay;
        }

        private DateTime GetReturnDateTime()
        {
            return dtpReturnDate.Value.Date + dtpReturnTime.Value.TimeOfDay;
        }

        // COMPUTE TOTAL 
        private void ComputeTotal()
        {
            if (selectedVehicleId == 0) return;

            computedTotal = RentalCalculator.CalculateTotal(
                GetPickupDateTime(),
                GetReturnDateTime(),
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

            // ====== INVOICE TOTAL ======
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

        private void dtpPickUpDate_ValueChanged(object sender, EventArgs e) => ComputeTotal();
        private void dtpReturnDate_ValueChanged(object sender, EventArgs e) => ComputeTotal();
        private void dtpPickupTime_ValueChanged(object sender, EventArgs e) => ComputeTotal();
        private void dtpReturnTime_ValueChanged(object sender, EventArgs e) => ComputeTotal();

        // PAYMENT to INVOICE 
        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPaymentType.Text = cmbPaymentType.Text;
            lblPaymentType.Text = cmbPaymentType.Text;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            lblAmount.Text = txtAmount.Text;
            lblAmount.Text = txtAmount.Text;
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPaymentMethod.Text = cmbPaymentMethod.Text;
            lblPaymentMethod.Text = cmbPaymentMethod.Text;
        }

        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPaymentStatus.Text = cmbPaymentStatus.Text;
            lblPaymentStatus.Text = cmbPaymentStatus.Text;
        }

        // CONFIRM RESERVATION
        private void btnConfirmReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomerId == 0 || selectedVehicleId == 0)
                {
                    MessageBox.Show("Please select customer and vehicle.");
                    return;
                }

                if (!decimal.TryParse(txtAmount.Text, out decimal amount))
                {
                    MessageBox.Show("Invalid payment amount.");
                    return;
                }

                int pickupMileage = Convert.ToInt32(dgAvailableVehicles.CurrentRow.Cells["Mileage"].Value);

                Reservation reservation = new Reservation
                {
                    UserID = UserSession.UserID,
                    CustomerID = selectedCustomerId,
                    VehicleID = selectedVehicleId,
                    PickUpDate = GetPickupDateTime(),
                    ReturnDate = GetReturnDateTime(),
                    Status = "Reserved",
                    PickupMileage = pickupMileage,
                    TotalAmount = computedTotal,
                    Payment = new Payment
                    {
                        PaymentType = cmbPaymentType.Text,
                        Amount = amount,
                        PaymentMethod = cmbPaymentMethod.Text,
                        PaymentStatus = cmbPaymentStatus.Text
                    }
                };

                int result = ReservationManager.SaveReservation(reservation);

                if (result > 0)
                {
                    MessageBox.Show("Reservation successfully saved!");
                    LoadAvailableVehicles();
                }
                else
                {
                    MessageBox.Show("Failed to save reservation.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            frmReceipt receipt = new frmReceipt();

            receipt.LoadInvoice(              
                date: DateTime.Now.ToString("MM/dd/yyyy"),
                customerName: lblCustomerName.Text,
                licenseNumber: lblLicenseNum.Text,
                contactNumber: lblContactNum.Text,
                address: lblCustomerAddress.Text,
                vehicle: lblVehicle.Text,
                dates: lblDates.Text,
                totalDays: lblDays.Text,
                rate: lblRate.Text,
                totalPrice: lblTotalPrice.Text,
                paymentType: lblPaymentType.Text,
                amount: lblAmount.Text,
                paymentMethod: lblPaymentMethod.Text,
                paymentStatus: lblPaymentStatus.Text
            );

            receipt.ShowDialog();
        }


    }
}


