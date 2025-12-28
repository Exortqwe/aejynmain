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

namespace aejynmain.UserControls
{
    public partial class UC_RentalOperations : UserControl
    {
        private decimal hourlyRate;
        private decimal dailyRate;
        private decimal weeklyRate;
        private decimal monthlyRate;
        private int selectedCustomerId = 0;
        private int selectedVehicleId = 0;
        private decimal computedTotal = 0;
        public UC_RentalOperations()
        {
            InitializeComponent();
            LoadAvailableVehicles();
            GetRentalDays();
            UpdateSummaryDates();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = AddCustomer.GetCustomers();
            string search = txtSearch.Text.Trim();

            selectedCustomerId = 0;

            foreach (DataRow dr in dt.Rows)
            {
                string fullName = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();
                string license = dr["LicenseNumber"].ToString();

                if (fullName.Contains(search) || license.Contains(search))
                {
                    selectedCustomerId = Convert.ToInt32(dr["CustomerID"]);

                    lblFullName.Text = fullName;
                    lblLicenseNumber.Text = license;
                    lblContactNumber.Text = dr["ContactNumber"].ToString();
                    lblAddress.Text = dr["Address"].ToString();

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
            dgAvailableVehicles.DataSource = VehicleFleet.GetAvailableVehicles();
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
                // validations...

                if (rbRentNow.Checked)
                {
                    SaveReservation("Rented");
                    UpdateVehicleStatus("Rented");
                    CreateRentalRecord();

                    MessageBox.Show("Vehicle rented successfully!");
                }
                else
                {
                    SaveReservation("Reserved");
                    UpdateVehicleStatus("Reserved");

                    MessageBox.Show("Reservation confirmed successfully!");
                }

                string rentalStatus = rbRentNow.Checked ? "Rented" : "Reserved";
                RentalOperations.SaveRental(
                  selectedCustomerId,
                  selectedVehicleId,
                  dtpPickUpDate.Value,
                  dtpReturnDate.Value,
                  computedTotal,
                  rentalStatus
                );

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

        private void SaveReservation(string status)
        {
            // Simple placeholder logic
            MessageBox.Show($"Reservation for {lblFullName.Text} and {lblVehicle.Text} saved as {status}.");
        }

        private void UpdateVehicleStatus(string status)
        {
            // Simple placeholder logic
            MessageBox.Show($"Vehicle {lblVehicle.Text} status updated to {status}.");
        }

        private void CreateRentalRecord()
        {
            // Simple placeholder logic
            MessageBox.Show($"Rental record created for {lblFullName.Text} from {dtpPickUpDate.Value:MMM dd} to {dtpReturnDate.Value:MMM dd}.");
        }
    }
}
