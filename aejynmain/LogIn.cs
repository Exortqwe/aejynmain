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
            frmCreateAccount ca = new frmCreateAccount();
            ca.Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblUser WHERE UserName = @username AND Password = @password";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            commandDatabase.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
            commandDatabase.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Welcome !!!");
                        MainForm mf = new MainForm();
                        mf.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Oops! Something went wrong. Please try again. ");
                }
                databaseConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
