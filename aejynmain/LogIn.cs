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
using MySqlConnector;

namespace aejynmain
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmCreateAccount ca = new frmCreateAccount())
            {
                ca.ShowDialog(this); // nag gamit og modal
            }

            //  mag resume ang runtime dri after sa create account close
            this.Show();
            txtUsername.Focus();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // validate input first
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter your username and password.", "Missing Information",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUsername.Focus();
                return; // mag stop ang execution
            }

            //  Continue only if input is valid
            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_Login", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                con.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Welcome!, You have successfully logged in.");

                        MainForm mf = new MainForm();
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Invalid username or password.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }
        
        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
