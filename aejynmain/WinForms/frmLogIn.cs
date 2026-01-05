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
using aejynmain.UserControls;
using MySql.Data.MySqlClient;

namespace aejynmain
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // una e validate input
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter your username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUsername.Focus();
                return; // mag stop ang execution
            }
            bool success = Login.LogIn(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (success)
            {
                   MessageBox.Show(
                        "LOGIN ROLE = " + UserSession.Role,
                        "DEBUG LOGIN"
                    );

                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAccount createAccount = new frmCreateAccount();
            createAccount.Show();
            this.Hide();
        }
    }
}
