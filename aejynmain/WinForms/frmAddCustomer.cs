using aejynmain.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aejynmain.AuthManager;
using aejynmain.Models;

namespace aejynmain
{
    public partial class frmAddCustomer : Form
    {
        private UC_Customers _parent;

        public frmAddCustomer(UC_Customers parent)
        {
            InitializeComponent();
            _parent = parent;

            // Optional: set default DateRegistered to today
            dtpDateRegistered.Value = DateTime.Today;
        }

        private void btnSaveCustomerDetails_Click(object sender, EventArgs e)
        {
            // 1️⃣ Age Verification (21+)
            if (!CustomerDetails.IsAgeValid(dtpBirthDate.Value))
            {
                int age = DateTime.Today.Year - dtpBirthDate.Value.Year;
                if (dtpBirthDate.Value.Date > DateTime.Today.AddYears(-age)) age--;
                MessageBox.Show(
                    $"Customer must be at least 21 years old.\nCurrent age: {age} years old.",
                    "Age Verification Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2️⃣ Determine Corporate status
            bool isCorporate = chkCorporate.Checked || !string.IsNullOrWhiteSpace(txtCompanyName.Text);

            // 3️⃣ Other info for CustomerType
            bool isBlacklisted = false; // implement your blacklisted check if needed
            int totalRentals = 0;       // optionally query DB for total rentals

            // 4️⃣ Auto-detect CustomerType
            CustomerType autoType = CustomerDetails.GetCustomerType(isBlacklisted, isCorporate, totalRentals);

            // 5️⃣ Call AddCustomer
            bool success = CustomerDetails.AddCustomer(
                txtFirstName.Text,
                txtLastName.Text,
                txtContactNum.Text,
                txtEmailAddress.Text,
                txtAddress.Text,
                cmbGender.Text,
                txtLicenseNumber.Text,
                dtpLicenseExpiry.Value,
                dtpBirthDate.Value,
                dtpDateRegistered.Value,
                txtName.Text,
                txtEmergencyContact.Text,
                cmbRelationship.Text,
                autoType,
                txtCompanyName.Text
            );

            // 6️⃣ Feedback + refresh
            if (success)
            {
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parent.LoadCustomers();   // refresh datagrid in parent UC
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}