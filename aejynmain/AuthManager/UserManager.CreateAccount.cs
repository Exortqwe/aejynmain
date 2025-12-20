using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.AuthManager
{
    internal class UserManager
    {
        private static readonly string connectionString =
            "server=localhost;port=3306;database=aejyndb;uid=root;pwd=;";

        public static bool CreateAccount(
            string firstName,
            string lastName,
            string username,
            string password,
            string role,
            string gender,
            DateTime birthDate,
            string contactNumber,
            string email,
            string address,
            DateTime DateCreated
        )
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_CreateUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_FirstName", firstName);
                    cmd.Parameters.AddWithValue("p_LastName", lastName);
                    cmd.Parameters.AddWithValue("p_UserName", username);
                    cmd.Parameters.AddWithValue("p_Password", password);
                    cmd.Parameters.AddWithValue("p_Role", role);
                    cmd.Parameters.AddWithValue("p_Gender", gender);
                    cmd.Parameters.AddWithValue("p_BirthDate", birthDate);
                    cmd.Parameters.AddWithValue("p_ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("p_EmailAddress", email);
                    cmd.Parameters.AddWithValue("p_Address", address);
                    cmd.Parameters.AddWithValue("p_DateCreated", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}