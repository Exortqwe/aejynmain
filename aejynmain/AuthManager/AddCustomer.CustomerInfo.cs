using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.AuthManager
{
    internal class AddCustomer
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";


        public static bool Customer(
            string firstName,
            string lastName,
            string contactNumber,
            string email,
            string address,
            string gender,
            string licenseNumber,
            DateTime licenseExpiryDate,
            DateTime birthDate,
            DateTime dateRegistered
        )
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_AddCustomer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_FirstName", firstName);
                    cmd.Parameters.AddWithValue("p_LastName", lastName);
                    cmd.Parameters.AddWithValue("p_ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("p_EmailAddress", email);
                    cmd.Parameters.AddWithValue("p_Address", address);
                    cmd.Parameters.AddWithValue("p_Gender", gender);
                    cmd.Parameters.AddWithValue("p_LicenseNumber", licenseNumber);
                    cmd.Parameters.AddWithValue("p_LicenseExpiryDate", licenseExpiryDate);
                    cmd.Parameters.AddWithValue("p_BirthDate", birthDate);
                    cmd.Parameters.AddWithValue("p_DateRegistered", dateRegistered);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static DataTable GetCustomers()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblcustomer", conn))
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            return dt;
        }
        public static bool DeleteCustomer(int CustomerID) // method para sa pag delete og customer
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using(MySqlCommand cmd = new MySqlCommand("DELETE FROM tblcustomer WHERE CustomerID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", CustomerID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true; // delete successfull
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
