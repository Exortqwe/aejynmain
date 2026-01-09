using aejynmain.AuthManager;
using aejynmain.UserControls;
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

namespace aejynmain.WinForms
{
    public partial class frmUserManagement : Form
    {
        private UC_UserManagement _ucUserManagement;
        public frmUserManagement(UC_UserManagement uc)
        {
            InitializeComponent();
            _ucUserManagement = uc;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // 🔴 VALIDATIONS
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender.");
                return;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Role.");
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Status.");
                return;
            }

            UserModel user = new UserModel
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),              // hash later
                Gender = cmbGender.SelectedItem.ToString(),      // ✅ Gender from ComboBox
                BirthDate = dtpBirthDate.Value.Date,            // ✅ BirthDate from DateTimePicker
                ContactNumber = txtContactNumber.Text.Trim(),   // ✅ ContactNumber
                EmailAddress = txtEmail.Text.Trim(),            // ✅ EmailAddress
                Address = txtAddress.Text.Trim(),               // ✅ Address
                Role = cmbRole.SelectedItem.ToString(),         // ✅ Role from ComboBox
                Status = cmbStatus.SelectedItem.ToString(),     // ✅ Status from ComboBox
                DateCreated = DateTime.Now
            };

            UserManagementManager.AddUser(user);

            MessageBox.Show("User added successfully");
            _ucUserManagement.LoadUsers();
            this.Close();
        }
    }
    
}
