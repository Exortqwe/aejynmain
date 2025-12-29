using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.AuthManager
{
    internal class AuthManager
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";
        public static int UserID { get; private set; }
        public static string UserName { get; private set; }
        public static string Role { get; private set; }
        public static bool LoggedIn => UserID > 0;

        public static bool LogIn(string username, string password)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_Login", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_username", username);
                cmd.Parameters.AddWithValue("p_password", password);
                con.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UserID = Convert.ToInt32(reader["UserID"]);
                        UserName = reader["UserName"].ToString();
                        Role = reader["Role"].ToString();

                        return true;

                    }
                }

            }
            return false;
        }
        public static void Logout()
        {
            UserID = 0;
            UserName = null;
            Role = null;
        }
    }
}
