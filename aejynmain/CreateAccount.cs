using aejynmain.AuthManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aejynmain
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            bool success = UserManager.CreateAccount(
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim(),
                cmbRole.Text,
                cmbGender.Text,
                dtpBirthDate.Value.Date,
                txtPhone.Text.Trim(),
                txtEmail.Text.Trim(),
                txtAddress.Text.Trim(),
                dtpDateCreated.Value.Date
            );

            if (success)
            {
                MessageBox.Show("Account created successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create account.", "Error");
            }
        }
    }
}
