using System;
using System.Net.Mail;
using System.Windows.Forms;
using aejynmain.AuthManager;
using aejynmain.Models;
using aejynmain.UserControls;

namespace aejynmain
{
    public partial class frmAddCustomer : Form
    {
        private readonly UC_Customers _parent;

        public frmAddCustomer(UC_Customers parent)
        {
            InitializeComponent();
            _parent = parent;

            // Defaults
            dtpDateRegistered.Value = DateTime.Now;
            dtpLicenseExpiry.Value = DateTime.Now.AddYears(1);
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-21); // must be 21+

            InitializeCustomerTypeComboBox();
        }

        private void InitializeCustomerTypeComboBox()
        {
            // Bind to enum to avoid string mismatches
            cmbCustomerType.DataSource = Enum.GetValues(typeof(CustomerType));
            cmbCustomerType.SelectedItem = CustomerType.Individual;
        }

        // SAVE
        private void btnSaveCustomerDetails_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!ValidateInputs(out string message))
            {
                MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Resolve type from combo (default to Individual if anything goes wrong)
            CustomerType customerType = GetSelectedCustomerTypeOrDefault();

            bool success = CustomerDetails.AddCustomer(
                firstName: txtFirstName.Text.Trim(),
                lastName: txtLastName.Text.Trim(),
                contactNumber: txtContactNum.Text.Trim(),
                email: txtEmailAddress.Text.Trim(),
                address: txtAddress.Text.Trim(),
                gender: cmbGender.Text,
                country: txtCountry.Text.Trim(),
                licenseNumber: txtLicenseNumber.Text.Trim(),
                licenseExpiryDate: dtpLicenseExpiry.Value,
                birthDate: dtpBirthDate.Value,
                dateRegistered: dtpDateRegistered.Value,
                emergencyContactName: txtName.Text.Trim(),
                emergencyContactNumber: txtEmergencyContact.Text.Trim(),
                emergencyContactRelationship: cmbRelationship.Text,
                type: customerType,
                companyName: txtCompanyName.Text.Trim()
            );

            if (success)
            {
                MessageBox.Show("Customer added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parent?.LoadCustomers(); // refresh parent grid
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add customer.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional: Clear button handler (wire this in designer if you have a Clear button)
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContactNum.Clear();
            txtEmailAddress.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
            txtCountry.Clear();
            txtLicenseNumber.Clear();
            dtpLicenseExpiry.Value = DateTime.Now.AddYears(1);
            dtpBirthDate.Value = DateTime.Now.AddYears(-21);
            txtName.Clear();
            txtEmergencyContact.Clear();
            cmbRelationship.SelectedIndex = -1;
            txtCompanyName.Clear();
            cmbCustomerType.SelectedItem = CustomerType.Individual;
            txtFirstName.Focus();
        }

        private bool ValidateInputs(out string message)
        {
            // Required fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtContactNum.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAddress.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                message = "Please fill in all required fields.";
                return false;
            }

            // Email format
            try { _ = new MailAddress(txtEmailAddress.Text.Trim()); }
            catch
            {
                message = "Please enter a valid email address.";
                return false;
            }

            // Age 21+
            if (!CustomerDetails.IsAgeValid(dtpBirthDate.Value))
            {
                int age = DateTime.Now.Year - dtpBirthDate.Value.Year;
                if (dtpBirthDate.Value.Date > DateTime.Now.AddYears(-age)) age--;
                message = $"Customer must be at least 21 years old. Current age: {age}.";
                return false;
            }

            // License expiry must be future if license number is provided
            if (!string.IsNullOrWhiteSpace(txtLicenseNumber.Text) &&
                dtpLicenseExpiry.Value.Date <= DateTime.Now)
            {
                message = "License expiry date must be in the future.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        private CustomerType GetSelectedCustomerTypeOrDefault()
        {
            // If bound to enum, this succeeds directly
            if (cmbCustomerType.SelectedItem is CustomerType enumVal)
                return enumVal;

            // If items are strings (e.g., “Walkin”), normalize and parse
            string text = cmbCustomerType.SelectedItem?.ToString() ?? "Individual";
            string normalized = text.Replace("-", "").Replace(" ", ""); // Walk-in/Walk in -> Walkin

            // Special-case mapping for WalkIn
            if (normalized.Equals("Walkin", StringComparison.OrdinalIgnoreCase))
                return CustomerType.WalkIn;

            if (Enum.TryParse(typeof(CustomerType), normalized, ignoreCase: true, out object parsed))
                return (CustomerType)parsed;

            return CustomerType.Individual;
        }
    }
}