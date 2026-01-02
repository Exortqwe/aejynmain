using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using aejynmain.Models;

namespace aejynmain.AuthManager
{
    internal class CustomerDetails
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        // CREATE / ADD
        public static bool AddCustomer(
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
                MessageBox.Show(ex.Message, "Error Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // READ / GET ALL CUSTOMERS
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblcustomer", conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                EmailAddress = reader["EmailAddress"].ToString(),
                                Address = reader["Address"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                LicenseNumber = reader["LicenseNumber"].ToString(),
                                LicenseExpiryDate = Convert.ToDateTime(reader["LicenseExpiryDate"]),
                                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                                DateRegistered = Convert.ToDateTime(reader["DateRegistered"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Fetching Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return customers;
        }

        // DELETE CUSTOMER
        public static bool DeleteCustomer(int customerId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tblcustomer WHERE CustomerID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // GET CUSTOMER HISTORY
        public static DataTable GetCustomerHistory(int customerId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_CustomerHistory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_CustomerID", customerId);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        int rowsAffected = da.Fill(dt);
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No history found for this customer.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Fetching Customer History", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public static bool UpdateCustomer(int customerID, string columnName, object newValue)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Create the SQL query to update the column of the customer based on the CustomerID
                    string query = $"UPDATE tblcustomer SET {columnName} = @NewValue WHERE CustomerID = @CustomerID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add the parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.Parameters.AddWithValue("@NewValue", newValue);

                        // Open the connection
                        conn.Open();

                        // Execute the query and check how many rows were affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // If rows were affected, return true (update successful)
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the update process
                MessageBox.Show(ex.Message, "Error Updating Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // CHECK IF CUSTOMER MEETS MINIMUM AGE (21 years old)
        public static bool IsAgeValid(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate.Date > DateTime.Today.AddYears(-age)) age--;
            return age >= 21;
        }
    }
}