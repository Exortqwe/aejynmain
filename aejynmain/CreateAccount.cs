using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace aejynmain
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_CreateUser", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("p_LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("p_UserName", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("p_Password", txtPassword.Text.Trim()); 
                cmd.Parameters.AddWithValue("p_Role", cmbRole.Text);
                cmd.Parameters.AddWithValue("p_Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("p_BirthDate", dtpBirthDate.Value.Date);
                cmd.Parameters.AddWithValue("p_ContactNumber", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("p_EmailAddress", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("p_Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("p_DateCreated", DateTime.Now);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!", "Success");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
               
            }
        }
    }
        
    
}
