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
using aejynmain.HelperMethod;

namespace aejynmain.UserControls
{
    public partial class UC_Returns : UserControl
    {
        int selectedRentalId = 0;
        decimal baseRentalAmount = 0;
        private DateTime currentPickup;
        private DateTime currentExpectedReturn;
        public UC_Returns()
        {
            InitializeComponent();
            UpdateBillingSummary();
            LoadUser();
        }
        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
        }
        private void UpdateBillingSummary()
        {
            if (selectedRentalId == 0) return;

            // 1️ Damage fee
            decimal damageFee = DamageHelper.CalculateTotal(
                cbScratches, cbDents, cbBrokenGlass,
                cbInteriorStains, cbTireDamage, cbPaintDamage);

            // 2️ Fuel fee
            decimal fuelFee = FuelHelper.CalculateFuelCharge(cmbFuelLevel.SelectedItem?.ToString());

            // 3️ Overdue fee (days)
            DateTime plannedReturn = Convert.ToDateTime(dgRentedVehicles.CurrentRow.Cells["ReturnDate"].Value).Date;
            DateTime actualReturn = dtpActualReturnDate.Value.Date;
            int overdueDays = (actualReturn - plannedReturn).Days;
            if (overdueDays < 0) overdueDays = 0;

            // 4️ Get daily rate from vehicle category
            decimal dailyRate = ReturnManager.GetDailyRate(selectedRentalId);
            decimal overdueFee = overdueDays * dailyRate;

            // 5️ Base rental amount (planned rental days * daily rate)
            // Uses pickup/expected return set on selection for consistent billing
            int rentalDays = (currentExpectedReturn.Date - currentPickup.Date).Days;
            if (rentalDays < 1) rentalDays = 1; // minimum 1 day
            baseRentalAmount = rentalDays * dailyRate;

            // 6️ Get deposit/previous payments
            decimal depositPaid = ReturnManager.GetTotalPaid(selectedRentalId);

            // 7️ Total charges = base rental + other fees
            decimal totalCharges = baseRentalAmount + damageFee + fuelFee + overdueFee;

            // 8️ Balance due (total charges minus deposit paid)
            decimal balanceDue = totalCharges - depositPaid;
            if (balanceDue < 0) balanceDue = 0; // Don't show negative balance

            // 9️ Update labels
            lblDamagesCharges.Text = damageFee.ToString("₱#,##0.00");
            lblFuelCharges.Text = fuelFee.ToString("₱#,##0.00");
            lblOverdueFee.Text = overdueFee.ToString("₱#,##0.00");
            lblDepositPaid.Text = depositPaid.ToString("₱#,##0.00");
            lblBalanceDue.Text = balanceDue.ToString("₱#,##0.00");
        }

        private void UC_Returns_Load(object sender, EventArgs e)
        {
            dgRentedVehicles.AutoGenerateColumns = true;
            dgRentedVehicles.DataSource = ReturnManager.GetActiveRentals();

            // ✅ DATE + TIME FORMAT
            if (dgRentedVehicles.Columns["PickupDate"] != null)
                dgRentedVehicles.Columns["PickupDate"]
                    .DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:tt";
            if (dgRentedVehicles.Columns["ReturnDate"] != null)
                dgRentedVehicles.Columns["ReturnDate"]
                    .DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:tt ";
            dgRentedVehicles.Columns["ActualReturnDate"].Visible = false;

            // Hide DailyRate and DaysOverdue columns
            if (dgRentedVehicles.Columns["DailyRate"] != null)
                dgRentedVehicles.Columns["DailyRate"].Visible = false;
            if (dgRentedVehicles.Columns["DaysOverdue"] != null)
                dgRentedVehicles.Columns["DaysOverdue"].Visible = false;

            UpdateBillingSummary();
        }
        private void dgRentedVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgRentedVehicles.Rows[e.RowIndex];

            // 1️ Get RentalID
            selectedRentalId = Convert.ToInt32(row.Cells["RentalID"].Value);

            // 2️ Populate vehicle info
            lblVehicleInspection.Text = $"{row.Cells["Make"].Value} {row.Cells["Model"].Value}";
            lblLicensePlate.Text = row.Cells["LicensePlate"].Value.ToString();

            // 3️ Rental duration (safe version)
            DateTime pickup = Convert.ToDateTime(row.Cells["PickupDate"].Value);
            DateTime returnDate = Convert.ToDateTime(row.Cells["ReturnDate"].Value);

            // Save these into fields so UpdateBillingSummary can access
            this.currentPickup = pickup;
            this.currentExpectedReturn = returnDate;

            int days = (returnDate - pickup).Days;
            lblRentalDuration.Text = days <= 1 ? "1 day" : $"{days} days";

            // 4️ Reset user inputs
            txtReturnMileage.Clear();
            cmbFuelLevel.SelectedIndex = -1;
            cmbCondition.SelectedIndex = -1;

            DamageHelper.ClearAll(
                cbScratches, cbDents, cbBrokenGlass,
                cbInteriorStains, cbTireDamage, cbPaintDamage);

            // 5️ Update billing summary (base + damage + fuel + overdue)
            UpdateBillingSummary();
        }
        private void Damage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBillingSummary();
        }
        private void cmbFuelLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBillingSummary();
        }
        private void btnReturnVehicle_Click(object sender, EventArgs e)
        {
            if (selectedRentalId == 0) return;
            if (cmbFuelLevel.SelectedItem == null)
            {
                MessageBox.Show("Please select fuel level.");
                return;
            }

            // Validate return mileage
            if (string.IsNullOrWhiteSpace(txtReturnMileage.Text) || !int.TryParse(txtReturnMileage.Text, out int returnMileage))
            {
                MessageBox.Show("Please enter a valid return mileage.");
                return;
            }

            int userId = UserSession.UserID;

            // Call manager to update tblrentals
            ReturnManager.ReturnVehicles(
                selectedRentalId,
                returnMileage,
                cmbFuelLevel.Text,
                cmbCondition.Text,
                dtpActualReturnDate.Value
            );

            // Update vehicle mileage to return mileage
            ReturnManager.UpdateVehicleMileage(selectedRentalId, returnMileage);

            // Save damages
            if (cbScratches.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Scratches", 500);
            if (cbDents.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Dents", 1000);
            if (cbBrokenGlass.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Broken Glass", 2000);
            if (cbInteriorStains.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Interior Stains", 500);
            if (cbTireDamage.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Tire Damage", 600);
            if (cbPaintDamage.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Paint Damage", 700);

            // Prepare amounts for persistence using labels (no recomputation for fees)
            decimal ParseAmount(string s) => decimal.TryParse(s.Replace("₱", "").Replace(",", "").Trim(), out var val) ? val : 0m;
            decimal damageFeeForInvoice = ParseAmount(lblDamagesCharges.Text);
            decimal fuelFeeForInvoice = ParseAmount(lblFuelCharges.Text);
            decimal overdueFeeForInvoice = ParseAmount(lblOverdueFee.Text);
            // Compute rental charges quickly (rentalDays * dailyRate)
            int rentalDaysForInvoice = (currentExpectedReturn.Date - currentPickup.Date).Days; if (rentalDaysForInvoice < 1) rentalDaysForInvoice = 1;
            decimal dailyRateForInvoice = ReturnManager.GetDailyRate(selectedRentalId);
            decimal rentalChargesForInvoice = rentalDaysForInvoice * dailyRateForInvoice;

            // Save payment (Balance Due) so it appears in Revenue Today
            string balanceDueText = lblBalanceDue.Text.Replace("₱", "").Replace(",", "").Trim();
            if (decimal.TryParse(balanceDueText, out decimal balanceDue) && balanceDue > 0)
            {
                // Get payment method if available, otherwise default to "Cash"
                string paymentMethod = "Cash"; // Default payment method

                // Save payment (no return value now)
                ReturnManager.SaveReturnPayment(selectedRentalId, balanceDue, paymentMethod, userId);

                // Mark all damages as paid since we collected the balance
                ReturnManager.MarkDamagesPaid(selectedRentalId);

                // Save/Update invoice record with all charges (4-parameter signature)
                ReturnManager.InsertOrUpdateInvoice(
                    selectedRentalId,
                    rentalCharges: rentalChargesForInvoice,
                    damageCharges: damageFeeForInvoice,
                    overdueCharges: overdueFeeForInvoice,
                    fuelCharges: fuelFeeForInvoice
                );
            }
            // Clear panel
            DamageHelper.ClearAll(cbScratches, cbDents, cbBrokenGlass, cbInteriorStains, cbTireDamage, cbPaintDamage);
            txtReturnMileage.Clear();
            cmbFuelLevel.SelectedIndex = -1;
            cmbCondition.SelectedIndex = -1;

            // Reload rentals
            dgRentedVehicles.DataSource = ReturnManager.GetActiveRentals();
            MessageBox.Show("Vehicle successfully returned.");
        }
    }
}
