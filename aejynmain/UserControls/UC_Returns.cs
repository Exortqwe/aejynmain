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

        }
        private void UpdateBillingSummary()
        {
            if (selectedRentalId == 0) return;

            // 1️⃣ Damage fee
            decimal damageFee = DamageHelper.CalculateTotal(
                cbScratches, cbDents, cbBrokenGlass,
                cbInteriorStains, cbTireDamage, cbPaintDamage);

            // 2️⃣ Fuel fee
            decimal fuelFee = FuelHelper.CalculateFuelCharge(cmbFuelLevel.SelectedItem?.ToString());

            // 3️⃣ Total paid / deposit
            decimal totalPaid = ReturnManager.GetTotalPaid(selectedRentalId);

            // 4️⃣ Overdue fee (per day)
            DateTime actualReturn = dtpActualReturnDate.Value;
            double overdueDays = (actualReturn - currentExpectedReturn).TotalDays;
            if (overdueDays < 0) overdueDays = 0;

            // Round up to next whole day
            int overdueDaysRounded = (int)Math.Ceiling(overdueDays);

            decimal dailyRate = ReturnManager.GetDailyRate(selectedRentalId);
            decimal overdueFee = overdueDaysRounded * dailyRate;

            // 5️⃣ Balance due
            decimal balanceDue = damageFee + fuelFee + overdueFee - totalPaid;

            // 6️⃣ Update labels
            lblDamagesCharges.Text = damageFee.ToString("₱#,##0.00");
            lblFuelCharges.Text = fuelFee.ToString("₱#,##0.00");
            lblDepositPaid.Text = totalPaid.ToString("₱#,##0.00");
            lblBalanceDue.Text = balanceDue.ToString("₱#,##0.00");
            lblOverdueFee.Text = overdueFee.ToString("₱#,##0.00"); // optional label
        }

        private void UC_Returns_Load(object sender, EventArgs e)
        {
            dgRentedVehicles.AutoGenerateColumns = true;
            dgRentedVehicles.DataSource = ReturnManager.GetActiveRentals();
            // Hide ActualReturnDate
            if (dgRentedVehicles.Columns["ActualReturnDate"] != null)
                dgRentedVehicles.Columns["ActualReturnDate"].Visible = false;
            UpdateBillingSummary();
        }
        private void dgRentedVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgRentedVehicles.Rows[e.RowIndex];

            // 1️⃣ Get RentalID
            selectedRentalId = Convert.ToInt32(row.Cells["RentalID"].Value);

            // 2️⃣ Populate vehicle info
            lblVehicleInspection.Text = $"{row.Cells["Make"].Value} {row.Cells["Model"].Value}";
            lblLicensePlate.Text = row.Cells["LicensePlate"].Value.ToString();

            // 3️⃣ Rental duration (safe version)
            DateTime pickup = Convert.ToDateTime(row.Cells["PickupDate"].Value);
            DateTime returnDate = Convert.ToDateTime(row.Cells["ReturnDate"].Value);

            // Save these into fields so UpdateBillingSummary can access
            this.currentPickup = pickup;
            this.currentExpectedReturn = returnDate;

            int days = (returnDate - pickup).Days;
            lblRentalDuration.Text = days <= 1 ? "1 day" : $"{days} days";

            // 4️⃣ Reset user inputs
            txtReturnMileage.Clear();
            cmbFuelLevel.SelectedIndex = -1;
            cmbCondition.SelectedIndex = -1;

            DamageHelper.ClearAll(
                cbScratches, cbDents, cbBrokenGlass,
                cbInteriorStains, cbTireDamage, cbPaintDamage);

            // 5️⃣ Update billing summary (base + damage + fuel + overdue)
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
                
            }
            int userId = User.UserID;

            // Call manager to update tblrentals
            ReturnManager.ReturnVehicle(
                selectedRentalId,
                Convert.ToInt32(txtReturnMileage.Text),
                cmbFuelLevel.Text,
                cmbCondition.Text,
                dtpActualReturnDate.Value
            );

            // Save damages
            if (cbScratches.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Scratches", 500);
            if (cbDents.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Dents", 1000);
            if (cbBrokenGlass.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Broken Glass", 2000);
            if (cbInteriorStains.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Interior Stains", 500);
            if (cbTireDamage.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Tire Damage", 600);
            if (cbPaintDamage.Checked) ReturnManager.InsertDamage(selectedRentalId, userId, "Paint Damage", 700);

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
