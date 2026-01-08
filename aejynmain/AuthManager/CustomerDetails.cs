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
        private static string connectionString =
            "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        // ADD NEW CUSTOMER
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
            DateTime dateRegistered,
            string emergencyContactName,
            string emergencyContactNumber,
            string emergencyContactRelationship,
            CustomerType type,
            string companyName)
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
                    cmd.Parameters.AddWithValue("p_EmergencyContactName", emergencyContactName);
                    cmd.Parameters.AddWithValue("p_EmergencyContactNumber", emergencyContactNumber);
                    cmd.Parameters.AddWithValue("p_EmergencyContactRelationship", emergencyContactRelationship);
                    cmd.Parameters.AddWithValue("p_CustomerType", type.ToString());
                    cmd.Parameters.AddWithValue("p_CompanyName", companyName);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Adding Customer",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // GET CUSTOMERS WITH CUSTOMER TYPE FILTER
        public static DataTable GetCustomers(string customerType = null)
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM tblcustomer";
            if (!string.IsNullOrEmpty(customerType))
                query += " WHERE CustomerType = @CustomerType";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(customerType))
                    cmd.Parameters.AddWithValue("@CustomerType", customerType);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                conn.Open();
                da.Fill(dt);
            }

            return dt;
        }

        // UPDATE CUSTOMER
        public static bool UpdateCustomer(int customerId, string columnName, object newValue)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = $"UPDATE tblcustomer SET {columnName} = @NewValue WHERE CustomerID = @CustomerID";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Handle null or empty values
                        if (newValue == null || (newValue is string strValue && string.IsNullOrWhiteSpace(strValue)))
                        {
                            cmd.Parameters.AddWithValue("@NewValue", DBNull.Value);
                        }
                        else if (newValue is DateTime dateValue)
                        {
                            cmd.Parameters.AddWithValue("@NewValue", dateValue);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NewValue", newValue);
                        }

                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // GET CUSTOMER TYPES
        public static List<string> GetCustomerTypes()
        {
            return new List<string>
            {
                "Individual",
                "Corporate",
                "Frequent",
                "Blacklisted",
                "Walk-in"
            };
        }

        // DELETE CUSTOMER
        public static bool DeleteCustomer(int customerId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM tblcustomer WHERE CustomerID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting Customer",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // CHECK IF CUSTOMER IS OF LEGAL AGE
        public static bool IsAgeValid(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate.Date > DateTime.Today.AddYears(-age))
                age--;
            return age >= 21;
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

        // DETERMINE CUSTOMER TYPE
        public static CustomerType GetCustomerType(
            bool isBlacklisted,
            bool isCorporate,
            int totalRentals)
        {
            if (isBlacklisted)
                return CustomerType.Blacklisted;
            if (isCorporate)
                return CustomerType.Corporate;
            if (totalRentals >= 10)
                return CustomerType.Frequent;

            return CustomerType.Individual;
        }

    }
}