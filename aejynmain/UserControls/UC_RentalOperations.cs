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
        private decimal dailyRate;
        private decimal weeklyRate;
        private decimal monthlyRate;
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
            string search = txtSearch.Text;
            foreach (DataRow dr in dt.Rows)
            {
                if ((dr["FirstName"] + " " + dr["LastName"]).Contains(search) || dr["LicenseNumber"].ToString().Contains(search))
                {
                    lblFullName.Text = dr["FirstName"] + " " + dr["LastName"];
                    lblLicenseNumber.Text = dr["LicenseNumber"].ToString();
                    lblContactNumber.Text = dr["ContactNumber"].ToString();
                    lblAddress.Text = dr["Address"].ToString();
                    return;
                }
            }
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

            lblVehicle.Text = row.Cells["Vehicle"].Value.ToString();

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
            lblTotalPrice.Text = total.ToString("₱#,##0.00");
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
                // simple na validation
                if (lblFullName.Text == "" || lblVehicle.Text == "")
                {
                    MessageBox.Show("Please select a customer and a vehicle first.",
                                    "Validation",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // confirm click
                MessageBox.Show("Reservation confirmed successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // mo gawas ra ni pag mag error
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while confirming reservation:\n\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
