using aejynmain.AuthManager;
using aejynmain.HelperMethod;
using aejynmain.Models;
using System;
using System.Windows.Forms;

namespace aejynmain.UserControls
{
    public partial class UC_Returns : UserControl
    {
        int selectedRentalId = 0;
        private DateTime currentPickup;
        private DateTime currentExpectedReturn;

        public UC_Returns()
        {
            InitializeComponent();
            LoadUser();

            cbScratches.CheckedChanged += Damage_CheckedChanged;
            cbDents.CheckedChanged += Damage_CheckedChanged;
            cbBrokenGlass.CheckedChanged += Damage_CheckedChanged;
            cbInteriorStains.CheckedChanged += Damage_CheckedChanged;
            cbTireDamage.CheckedChanged += Damage_CheckedChanged;
            cbPaintDamage.CheckedChanged += Damage_CheckedChanged;
        }

        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
        }

        private decimal UpdateBillingSummary()
        {
            if (selectedRentalId == 0)
                return 0m;

            decimal damageFee = DamageHelper.CalculateTotal(
                cbScratches, cbDents, cbBrokenGlass,
                cbInteriorStains, cbTireDamage, cbPaintDamage);

            decimal fuelFee = FuelHelper.CalculateFuelCharge(
                cmbFuelLevel.SelectedItem?.ToString());

            DateTime actualReturn = dtpActualReturnDate.Value.Date;
            DateTime plannedReturn = currentExpectedReturn.Date;

            int overdueDays = (actualReturn - plannedReturn).Days;
            if (overdueDays < 0) overdueDays = 0;

            decimal dailyRate = ReturnManager.GetDailyRate(selectedRentalId);

            decimal overdueFee = overdueDays * dailyRate;

            int rentalDays = (plannedReturn - currentPickup.Date).Days;
            if (rentalDays < 1) rentalDays = 1;

            decimal baseRental = rentalDays * dailyRate;

            decimal additionalCharges = damageFee + fuelFee + overdueFee;

            decimal totalCharges = baseRental + additionalCharges;
            decimal depositPaid = ReturnManager.GetDepositPaid(selectedRentalId);

            decimal balanceDue = totalCharges - depositPaid;
            decimal refundAmount = 0m;

            if (balanceDue < 0)
            {
                refundAmount = Math.Abs(balanceDue);
                balanceDue = 0;
            }

            lblRentalCharges.Text = baseRental.ToString("₱#,##0.00");
            lblAdditionalCharges.Text = additionalCharges.ToString("₱#,##0.00");
            lblTotalCharges.Text = totalCharges.ToString("₱#,##0.00");

            lblDepositPaid.Text = depositPaid.ToString("₱#,##0.00");
            lblBalanceDue.Text = balanceDue.ToString("₱#,##0.00");
            lblRefund.Text = refundAmount.ToString("₱#,##0.00");

            return refundAmount;
        }


        private void UC_Returns_Load(object sender, EventArgs e)
        {
            dgRentedVehicles.AutoGenerateColumns = true;
            dgRentedVehicles.DataSource = ReturnManager.GetActiveRentals();

            if (dgRentedVehicles.Columns["PickupDate"] != null)
                dgRentedVehicles.Columns["PickupDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

            if (dgRentedVehicles.Columns["ReturnDate"] != null)
                dgRentedVehicles.Columns["ReturnDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

            if (dgRentedVehicles.Columns["ActualReturnDate"] != null)
                dgRentedVehicles.Columns["ActualReturnDate"].Visible = false;

            if (dgRentedVehicles.Columns["DailyRate"] != null)
                dgRentedVehicles.Columns["DailyRate"].Visible = false;

            if (dgRentedVehicles.Columns["DaysOverdue"] != null)
                dgRentedVehicles.Columns["DaysOverdue"].Visible = false;
        }

        private void dgRentedVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgRentedVehicles.Rows[e.RowIndex];
            selectedRentalId = Convert.ToInt32(row.Cells["RentalID"].Value);

            lblVehicleInspection.Text = $"{row.Cells["Make"].Value} {row.Cells["Model"].Value}";
            lblLicensePlate.Text = row.Cells["LicensePlate"].Value.ToString();

            currentPickup = Convert.ToDateTime(row.Cells["PickupDate"].Value);
            currentExpectedReturn = Convert.ToDateTime(row.Cells["ReturnDate"].Value);

            int days = (currentExpectedReturn - currentPickup).Days;
            lblRentalDuration.Text = days <= 1 ? "1 day" : $"{days} days";

            txtReturnMileage.Clear();
            cmbFuelLevel.SelectedIndex = -1;
            cmbCondition.SelectedIndex = -1;

            DamageHelper.ClearAll(
                cbScratches, cbDents, cbBrokenGlass,
                cbInteriorStains, cbTireDamage, cbPaintDamage);

            UpdateBillingSummary();
        }


        private void Damage_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb && cb.Checked)
            {
                if (cmbCondition.Text == "Excellent" || cmbCondition.Text == "Good")
                {
                    MessageBox.Show(
                        $"Cannot mark damage when condition is {cmbCondition.Text}.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cb.Checked = false;
                    return;
                }
            }
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

            if (!int.TryParse(txtReturnMileage.Text, out int returnMileage))
            {
                MessageBox.Show("Please enter a valid return mileage.");
                return;
            }

            int userId = UserSession.UserID;

            ReturnManager.ReturnVehicles(
                selectedRentalId,
                returnMileage,
                cmbFuelLevel.Text,
                cmbCondition.Text,
                dtpActualReturnDate.Value);

            ReturnManager.UpdateVehicleMileage(selectedRentalId, returnMileage);

            if (cbScratches.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Scratches", 500);
            if (cbDents.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Dents", 1000);
            if (cbBrokenGlass.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Broken Glass", 2000);
            if (cbInteriorStains.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Interior Stains", 500);
            if (cbTireDamage.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Tire Damage", 600);
            if (cbPaintDamage.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Paint Damage", 700);

            decimal refundAmount = UpdateBillingSummary();
            decimal balanceDue = decimal.Parse(
                lblBalanceDue.Text.Replace("₱", "").Replace(",", ""));

            if (balanceDue > 0)
            {
                string paymentMethod = cmbPaymentMethod.SelectedItem?.ToString() ?? "Cash";
                ReturnManager.SaveReturnPayment(selectedRentalId, balanceDue, paymentMethod, userId);
                ReturnManager.MarkDamagesPaid(selectedRentalId);
            }

            if (refundAmount > 0)
            {
                MessageBox.Show(
                    $"Refund customer ₱{refundAmount:N2}",
                    "Refund Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            dgRentedVehicles.DataSource = ReturnManager.GetActiveRentals();
            MessageBox.Show("Vehicle successfully returned.");
        }
    }
}