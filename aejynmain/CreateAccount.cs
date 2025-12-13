using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace aejynmain
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogIn ob = new frmLogIn();
            ob.Show();
            this.Hide();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string gender = cmbGender.Text;
                string role = cmbRole.Text;
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string address = txtAddress.Text.Trim();
                DateTime birthDate = dtpBirthDate.Value;
                DateTime dateCreated = DateTime.Now;

                // Basic validation
                if (firstName == "" || lastName == "" || username == "" || password == "")
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                string query = @"INSERT INTO tbluser
        (FirstName, LastName, UserName, Password, Role, Gender, BirthDate, ContactNumber, EmailAddress, Address, DateCreated)
        VALUES
        (@FirstName, @LastName, @UserName, @Password, @Role, @Gender, @BirthDate, @ContactNumber, @EmailAddress, @Address, @DateCreated)";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password); // plain for now
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                    cmd.Parameters.AddWithValue("@ContactNumber", phone);
                    cmd.Parameters.AddWithValue("@EmailAddress", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@DateCreated", dateCreated);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account created successfully!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
