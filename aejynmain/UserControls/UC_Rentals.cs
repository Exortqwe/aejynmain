using aejynmain.AuthManager;
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
            GetRentalDays();
            UpdateSummaryDates();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Customer> customers = CustomerDetails.GetCustomers();
            string search = txtSearch.Text.Trim();
            selectedCustomerId = 0;

            foreach (Customer c in customers)
            {
                string fullName = c.FirstName + " " + c.LastName;
                string license = c.LicenseNumber;

                if (fullName.Contains(search) || license.Contains(search))
                {
                    selectedCustomerId = c.CustomerID;
                    lblFullName.Text = fullName;
                    lblLicenseNumber.Text = license;
                    lblContactNumber.Text = c.ContactNumber;
                    lblAddress.Text = c.Address;
                    return;
                }
            }

            MessageBox.Show("Customer not found.");
            lblFullName.Text = "";
            lblLicenseNumber.Text = "";
            lblContactNumber.Text = "";
            lblAddress.Text = "";
        }
        private void LoadAvailableVehicles()
        {
            dgAvailableVehicles.DataSource = RentalOperation.GetAvailableVehicles();
        }
        private int GetRentalDays()
        {
            DateTime pickup = dtpPickUpDate.Value.Date;
            DateTime ret = dtpReturnDate.Value.Date;

            int days = (ret - pickup).Days + 1;
            return days <= 0 ? 1 : days;
        }
        private void dgAvailableVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgAvailableVehicles.Rows[e.RowIndex];
            selectedVehicleId = Convert.ToInt32(row.Cells["VehicleID"].Value);


            hourlyRate = Convert.ToDecimal(row.Cells["HourlyRate"].Value);
            dailyRate = Convert.ToDecimal(row.Cells["DailyRate"].Value);
            weeklyRate = Convert.ToDecimal(row.Cells["WeeklyRate"].Value);
            monthlyRate = Convert.ToDecimal(row.Cells["MonthlyRate"].Value);

            ComputeTotal();
        }
        private void ComputeTotal()
        {

            if (dailyRate == 0) return;
            int days = GetRentalDays();
            decimal total = 0;
            string rateUsed = "";
            lblRate.Text =
            days >= 30 ? "Monthly Rate" :
            days >= 7 ? "Weekly Rate" :
            "Daily Rate";

            if (days >= 30)
            {
                int months = days / 30;
                int remainingDays = days % 30;

                total = (months * monthlyRate) + (remainingDays * dailyRate);
                rateUsed = "Monthly";
            }
            else if (days >= 7)
            {
                int weeks = days / 7;
                int remainingDays = days % 7;

                total = (weeks * weeklyRate) + (remainingDays * dailyRate);
                rateUsed = "Weekly";
            }
            else
            {
                total = days * dailyRate;
                rateUsed = "Daily";
            }

            lblDays.Text = days.ToString();
            computedTotal = total;
            lblTotalPrice.Text = total.ToString("₱#,###.00");
            UpdateSummaryDates();
        }
        private void UpdateSummaryDates()
        {
            lblDates.Text = $"{dtpPickUpDate.Value:MMM dd, yyyy} - {dtpReturnDate.Value:MMM dd, yyyy}";
        }
        private void dtpPickupDate_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // --- BASIC VALIDATION ---
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

                // ✅ CREATE RENTAL OBJECT (IBUTANG DIRI)
                Rental rental = new Rental
                {
                    CustomerID = selectedCustomerId,
                    VehicleID = selectedVehicleId,
                    PickUpDate = dtpPickUpDate.Value,
                    ReturnDate = dtpReturnDate.Value,
                    Status = rbRentNow.Checked ? "Rented" : "Reserved",
                    TotalAmount = computedTotal,
                    Payment = new Payment
                    {
                        PaymentType = cmbPaymentType.Text,
                        Amount = amount,
                        PaymentMethod = cmbPaymentMethod.Text,
                        PaymentStatus = "Paid"
                    }
                };

                RentalOperation.SaveRental(rental);

                MessageBox.Show("Rental successfully saved!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while confirming:\n\n" + ex.Message);
            }
        }
        private void rbRentNow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRentNow.Checked)
            {


                dtpPickUpDate.Value = DateTime.Today;
                dtpPickUpDate.Enabled = false;
            }
        }

    }
}
