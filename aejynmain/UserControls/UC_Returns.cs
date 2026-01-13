using aejynmain.AuthManager;
using aejynmain.HelperMethod;
using aejynmain.Models;
using aejynmain.WinForms;
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
            LoadCleaningFees();

            cbScratches.CheckedChanged += Damage_CheckedChanged;
            cbDents.CheckedChanged += Damage_CheckedChanged;
            cbBrokenGlass.CheckedChanged += Damage_CheckedChanged;
            cbInteriorStains.CheckedChanged += Damage_CheckedChanged;
            cbTireDamage.CheckedChanged += Damage_CheckedChanged;
            cbPaintDamage.CheckedChanged += Damage_CheckedChanged;

            cmbFuelLevel.SelectedIndexChanged += cmbFuelLevel_SelectedIndexChanged;
            cmbCleaningFees.SelectedIndexChanged += cmbCleaningFees_SelectedIndexChanged;
        }

        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
        }

        // ===================== CLEANING FEES =====================
        private void LoadCleaningFees()
        {
            cmbCleaningFees.Items.Clear();

            cmbCleaningFees.Items.Add(new CleaningFeeItem("No Cleaning", 0m));
            cmbCleaningFees.Items.Add(new CleaningFeeItem("Light Cleaning", 300m));
            cmbCleaningFees.Items.Add(new CleaningFeeItem("Heavy Cleaning", 700m));
            cmbCleaningFees.Items.Add(new CleaningFeeItem("Extreme / Biohazard", 1500m));

            cmbCleaningFees.DisplayMember = "Name";
            cmbCleaningFees.ValueMember = "Amount";
            cmbCleaningFees.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCleaningFees.SelectedIndex = 0;
        }

        private decimal GetCleaningFee()
        {
            if (cmbCleaningFees.SelectedItem is CleaningFeeItem fee)
                return fee.Amount;

            return 0m;
        }

        // ===================== BILLING SUMMARY =====================
        private decimal UpdateBillingSummary()
        {
            if (selectedRentalId == 0)
                return 0m;

            decimal damageFee = DamageHelper.CalculateTotal(
                cbScratches, cbDents, cbBrokenGlass,
                cbInteriorStains, cbTireDamage, cbPaintDamage);

            decimal fuelFee = FuelHelper.CalculateFuelCharge(
                cmbFuelLevel.SelectedItem?.ToString());

            decimal cleaningFee = GetCleaningFee();

            DateTime actualReturn = dtpActualReturnDate.Value.Date;
            DateTime plannedReturn = currentExpectedReturn.Date;

            int overdueDays = (actualReturn - plannedReturn).Days;
            if (overdueDays < 0) overdueDays = 0;

            decimal dailyRate = ReturnManager.GetDailyRate(selectedRentalId);
            decimal overdueFee = overdueDays * dailyRate;

            int rentalDays = (plannedReturn - currentPickup.Date).Days;
            if (rentalDays < 1) rentalDays = 1;

            decimal baseRental = rentalDays * dailyRate;

            decimal additionalCharges = damageFee + fuelFee + overdueFee + cleaningFee;
            decimal totalCharges = baseRental + additionalCharges;
            decimal subtotal = baseRental + additionalCharges; // Calculate subtotal

            decimal depositPaid = ReturnManager.GetDepositPaid(selectedRentalId);
            decimal balanceDue = totalCharges - depositPaid;
            decimal refundAmount = 0m;

            if (balanceDue < 0)
            {
                refundAmount = Math.Abs(balanceDue);
                balanceDue = 0;
            }

            // Update all labels
            lblRentalCharges.Text = baseRental.ToString("₱#,##0.00");
            lblAdditionalCharges.Text = additionalCharges.ToString("₱#,##0.00");
            lblCleaningFees.Text = cleaningFee.ToString("₱#,##0.00");
            lblSubTotal.Text = subtotal.ToString("₱#,##0.00"); 
            lblTotalCharges.Text = totalCharges.ToString("₱#,##0.00");

            lblDepositPaid.Text = depositPaid.ToString("₱#,##0.00");
            lblBalanceDue.Text = balanceDue.ToString("₱#,##0.00");
            lblRefund.Text = refundAmount.ToString("₱#,##0.00");

            return refundAmount;
        }

        // ===================== LOAD RENTALS =====================
        private void UC_Returns_Load(object sender, EventArgs e)
        {
            dgRentedVehicles.AutoGenerateColumns = true;
            dgRentedVehicles.DataSource = ReturnManager.GetActiveRentals();
        }

        private void dgRentedVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgRentedVehicles.Rows[e.RowIndex];

            selectedRentalId = Convert.ToInt32(row.Cells["RentalID"].Value);
            lblRentalID.Text = selectedRentalId.ToString();
            lblCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
            lblVehicleInspection.Text = $"{row.Cells["Make"].Value} {row.Cells["Model"].Value}";
            lblLicensePlate.Text = row.Cells["LicensePlate"].Value.ToString();

            currentPickup = Convert.ToDateTime(row.Cells["PickupDate"].Value);
            currentExpectedReturn = Convert.ToDateTime(row.Cells["ReturnDate"].Value);

            int days = (currentExpectedReturn - currentPickup).Days;
            lblRentalDuration.Text = days <= 1 ? "1 day" : $"{days} days";

            txtReturnMileage.Clear();
            cmbFuelLevel.SelectedIndex = -1;
            cmbCondition.SelectedIndex = -1;
            cmbCleaningFees.SelectedIndex = 0;

            DamageHelper.ClearAll(
                cbScratches, cbDents, cbBrokenGlass,
                cbInteriorStains, cbTireDamage, cbPaintDamage);

            UpdateBillingSummary();
        }

        // ===================== EVENTS =====================
        private void Damage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBillingSummary();
        }

        private void cmbFuelLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBillingSummary();
        }

        private void cmbCleaningFees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBillingSummary();
        }

        // ===================== RETURN VEHICLE =====================
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

            // --- Return vehicle ---
            ReturnManager.ReturnVehicles(
                selectedRentalId,
                returnMileage,
                cmbFuelLevel.Text,
                cmbCondition.Text,
                dtpActualReturnDate.Value);

            ReturnManager.UpdateVehicleMileage(selectedRentalId, returnMileage);

            // --- Calculate fees ---
            decimal damageFee = DamageHelper.CalculateTotal(
                cbScratches, cbDents, cbBrokenGlass,
                cbInteriorStains, cbTireDamage, cbPaintDamage);

            decimal fuelFee = FuelHelper.CalculateFuelCharge(cmbFuelLevel.SelectedItem?.ToString());
            decimal cleaningFee = GetCleaningFee();

            DateTime actualReturn = dtpActualReturnDate.Value.Date;
            DateTime plannedReturn = currentExpectedReturn.Date;

            int overdueDays = (actualReturn - plannedReturn).Days;
            if (overdueDays < 0) overdueDays = 0;

            decimal dailyRate = ReturnManager.GetDailyRate(selectedRentalId);
            decimal overdueFee = overdueDays * dailyRate;

            int rentalDays = (plannedReturn - currentPickup.Date).Days;
            if (rentalDays < 1) rentalDays = 1;

            decimal baseRental = rentalDays * dailyRate;

            // --- Insert/Update invoice ---
            ReturnManager.InsertOrUpdateInvoice(
                selectedRentalId,
                baseRental,
                damageFee,
                overdueFee,
                fuelFee,
                cleaningFee
            );

            // --- Insert damages ---
            if (cbScratches.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Scratches", 500);
            if (cbDents.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Dents", 1000);
            if (cbBrokenGlass.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Broken Glass", 2000);
            if (cbInteriorStains.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Interior Stains", 500);
            if (cbTireDamage.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Tire Damage", 600);
            if (cbPaintDamage.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Paint Damage", 700);

            // --- Update billing summary ---
            decimal refundAmount = UpdateBillingSummary();
            decimal balanceDue = decimal.Parse(lblBalanceDue.Text.Replace("₱", "").Replace(",", ""));

            // --- Save payment ---
            if (balanceDue > 0)
            {
                string paymentMethod = cmbPaymentMethod.SelectedItem?.ToString() ?? "Cash";
                ReturnManager.SaveReturnPayment(selectedRentalId, balanceDue, paymentMethod, userId);
                ReturnManager.MarkDamagesPaid(selectedRentalId);
            }

            // --- Refund if any ---
            if (refundAmount > 0)
            {
                MessageBox.Show($"Refund customer ₱{refundAmount:N2}", "Refund Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // --- Refresh grid ---
            dgRentedVehicles.DataSource = ReturnManager.GetActiveRentals();
            MessageBox.Show("Vehicle successfully returned.");
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPaymentMethod.Text = cmbPaymentMethod.SelectedItem?.ToString();
        }
        private decimal SafeDecimal(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0m;

            text = text.Replace("₱", "").Replace(",", "").Trim();
            return decimal.TryParse(text, out decimal value) ? value : 0m;
        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (selectedRentalId == 0)
            {
                MessageBox.Show("Please select a rental first.");
                return;
            }

            frmBilling receipt = new frmBilling();

            receipt.LoadBillingData(
                lblCustomerName.Text,
                lblRentalID.Text,

                SafeDecimal(lblRentalCharges.Text),
                SafeDecimal(lblAdditionalCharges.Text),
                SafeDecimal(lblCleaningFees.Text),
                SafeDecimal(lblTotalCharges.Text),   // sub total
                SafeDecimal(lblDepositPaid.Text),
                SafeDecimal(lblBalanceDue.Text),
                SafeDecimal(lblRefund.Text),

                cmbPaymentMethod.SelectedItem?.ToString() ?? "Cash"
            );

            receipt.ShowDialog();
        }
    }
}