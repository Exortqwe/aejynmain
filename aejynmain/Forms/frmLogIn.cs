using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmCreateAccount ca = new frmCreateAccount())
            {
                ca.ShowDialog(this); //modal ni siya

            }

            //mag resume ang runtime dri after sa create account
            this.Show();
            txtUsername.Focus();
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

            bool success = AuthManager.AuthManager.LogIn(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (success)
            {
                MessageBox.Show("Welcome!, You have successfully logged in.");


                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
                   
        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
