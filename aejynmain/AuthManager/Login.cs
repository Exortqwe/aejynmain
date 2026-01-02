using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aejynmain.Models;

namespace aejynmain.AuthManager
{
    internal class Login
    {
        private static string connectionString =
            "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        public static bool LogIn(string username, string password)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand("sp_Login", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_username", username);
                        cmd.Parameters.AddWithValue("@p_password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User.SetUser(
                                    Convert.ToInt32(reader["UserID"]),
                                    reader["UserName"].ToString(),
                                    reader["Role"].ToString()
                                );
                                return true;
                            }
                        }
                    }
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        public static void Logout()
        {
            User.Logout();
        }
    }
}