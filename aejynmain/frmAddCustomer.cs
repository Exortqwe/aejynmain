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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnSaveCustomerDetails_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtFname1.Text) ||
                string.IsNullOrWhiteSpace(txtLname1.Text))
            {
                MessageBox.Show(
                    "First Name and Last Name are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string connectionString =
                "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_AddCustomer", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_FirstName", txtFname1.Text.Trim());
                cmd.Parameters.AddWithValue("@p_LastName", txtLname1.Text.Trim());
                cmd.Parameters.AddWithValue("@p_ContactNumber", txtContactNum1.Text.Trim());
                cmd.Parameters.AddWithValue("@p_EmailAddress", txtEmail1.Text.Trim());
                cmd.Parameters.AddWithValue("@p_Address", txtAddress1.Text.Trim());
                cmd.Parameters.AddWithValue("@p_Gender", cbGender1.Text);
                cmd.Parameters.AddWithValue("@p_LicenseNumber", txtLicenseNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@p_LicenseExpiryDate", dtLicenseExpiry.Value.Date);
                cmd.Parameters.AddWithValue("@p_BirthDate", dtBoDate.Value.Date);
                cmd.Parameters.AddWithValue("@p_DateRegistered", dtDateRegistered.Value.Date);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer saved successfully!", "Success",   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }
        }
    }
}