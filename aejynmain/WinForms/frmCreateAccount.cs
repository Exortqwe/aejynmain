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
            bool success = AuthManager.UserManager.CreateAccount(
                txtFirstName.Text,
                txtLastName.Text,
                txtUsername.Text,
                txtPassword.Text,
                cmbRole.Text,
                cmbGender.Text,
                dtpBirthDate.Value.Date,
                txtPhone.Text,
                txtEmail.Text,
                txtAddress.Text,
                dtpDateCreated.Value.Date
            );

            if (success)
            {
                MessageBox.Show("Account created successfully!", "Success");
                this.Hide();
                frmLogIn loginForm = new frmLogIn();
                loginForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create account.", "Error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogIn login = new frmLogIn();
            login.Show();
            this.Hide();
        }
    }
}
