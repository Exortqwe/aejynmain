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
using aejynmain.Models;

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
            bool success = LoginManager.LogIn(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (success)
            {
                // Show welcome message
                string userRole = UserSession.IsAdmin ? "Admin" : "Rental Agent";
                string welcomeMessage = $"Welcome{(UserSession.IsAdmin ? " back" : "")}, {UserSession.Username}! ({userRole})";
                MessageBox.Show(welcomeMessage, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
    }
}
