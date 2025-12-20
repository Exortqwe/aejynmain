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
    public partial class frmAddCustomer : Form
    {
        public event Action CustomerSaved;
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        private void btnSaveCustomerDetails_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show(
                    "First Name and Last Name are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb; Allow User Variables=True;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_AddCustomer", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_FirstName", txtFirstName.ToString);
                cmd.Parameters.AddWithValue("@p_LastName", txtLastName.ToString);
                cmd.Parameters.AddWithValue("@p_ContactNumber", txtContactNum.ToString);
                cmd.Parameters.AddWithValue("@p_EmailAddress", txtEmailAddress.ToString);
                cmd.Parameters.AddWithValue("@p_Address", txtAddress.ToString);
                cmd.Parameters.AddWithValue("@p_Gender", cbGender.ToString);
                cmd.Parameters.AddWithValue("@p_LicenseNumber", txtLicenseNumber.ToString);
                cmd.Parameters.AddWithValue("@p_LicenseExpiryDate", dtLicenseExpiry.Value.Date);
                cmd.Parameters.AddWithValue("@p_BirthDate", dtBoDate.Value.Date);
                cmd.Parameters.AddWithValue("@p_DateRegistered", dtDateRegistered.Value.Date);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer saved successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    CustomerSaved?.Invoke(); //important
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