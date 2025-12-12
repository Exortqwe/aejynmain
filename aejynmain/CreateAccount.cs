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
using MySql.Data.MySqlClient;

namespace aejynmain
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_user;";
        public void createAccount()
        {
            string query = "SELECT * FROM tblUser WHERE username=" + txtUsername1.Text + "'AND password='" + txtPassword.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Successfully created an account.");
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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogIn ob = new frmLogIn();
            ob.Show();
            this.Hide();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {

        }
    }
}
