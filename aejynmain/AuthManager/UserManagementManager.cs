using aejynmain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace aejynmain.AuthManager
{
    public static class UserManagementManager
    {
        private static readonly string ConnectionString =
            "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        public static void AddUser(UserModel user)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_AddUser", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("p_LastName", user.LastName);
                cmd.Parameters.AddWithValue("p_Username", user.Username);
                cmd.Parameters.AddWithValue("p_Password", user.Password);
                cmd.Parameters.AddWithValue("p_Gender", user.Gender);
                cmd.Parameters.AddWithValue("p_BirthDate", user.BirthDate);
                cmd.Parameters.AddWithValue("p_ContactNumber", user.ContactNumber);
                cmd.Parameters.AddWithValue("p_EmailAddress", user.EmailAddress);
                cmd.Parameters.AddWithValue("p_Address", user.Address);
                cmd.Parameters.AddWithValue("p_Role", user.Role);
                cmd.Parameters.AddWithValue("p_UserStatus", user.Status);
                cmd.Parameters.AddWithValue("p_DateCreated", user.DateCreated);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Retrieves all users from the database.
        /// </summary>
        /// <returns>List of UserModel</returns>
        public static List<UserModel> GetAllUsers()
        {
            List<UserModel> users = new List<UserModel>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_GetAllUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new UserModel
                            {
                                UserID = reader.GetInt32("UserID"),
                                FirstName = reader.GetString("FirstName"),
                                LastName = reader.GetString("LastName"),
                                Username = reader.GetString("Username"),
                                Gender = reader.GetString("Gender"),

                                BirthDate = reader.IsDBNull("BirthDate")
                                    ? (DateTime?)null
                                    : reader.GetDateTime("BirthDate"),

                                ContactNumber = reader.GetString("ContactNumber"),
                                EmailAddress = reader.GetString("EmailAddress"),
                                Address = reader.GetString("Address"),
                                Role = reader.GetString("Role"),
                                Status = reader.GetString("Status"),

                                DateCreated = reader.IsDBNull("DateCreated")
                                ? DateTime.Now
                                : reader.GetDateTime("DateCreated")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to retrieve users.", ex);
            }

            return users;
        }
        public static void DeleteUser(int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_DeleteUser", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_UserID", userId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateUser(UserModel user)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_UpdateUser", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_UserID", user.UserID);
                cmd.Parameters.AddWithValue("p_FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("p_LastName", user.LastName);
                cmd.Parameters.AddWithValue("p_Username", user.Username);
                cmd.Parameters.AddWithValue("p_Gender", user.Gender);
                cmd.Parameters.AddWithValue("p_BirthDate", user.BirthDate.HasValue ? user.BirthDate.Value : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("p_ContactNumber", user.ContactNumber);
                cmd.Parameters.AddWithValue("p_EmailAddress", user.EmailAddress);
                cmd.Parameters.AddWithValue("p_Address", user.Address);
                cmd.Parameters.AddWithValue("p_Role", user.Role);
                cmd.Parameters.AddWithValue("p_UserStatus", user.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}