using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace aejynmain.AuthManager
{
    internal class VehicleFleet
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";
        public static bool AddVehicle(
               string Category,
               string Make,
               string Model,
               string LicensePlate,
               int Mileage,
               int    Year,
               string VIN,
               string Color,
               string Transmission,
               string FuelType,
               int    SeatingCapacity,
               decimal DailyRate,
               decimal WeeklyRate,
               decimal MonthlyRate,
               string Status
               )
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_VehicleFleet", conn)) // stored procedure
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("p_Category", Category);
                    cmd.Parameters.AddWithValue("p_Make", Make);
                    cmd.Parameters.AddWithValue("p_Model", Model);
                    cmd.Parameters.AddWithValue("p_LicensePlate", LicensePlate);
                    cmd.Parameters.AddWithValue("p_Mileage", Mileage);
                    cmd.Parameters.AddWithValue("p_V_Year", Year);
                    cmd.Parameters.AddWithValue("p_VIN", VIN);
                    cmd.Parameters.AddWithValue("p_Transmission", Color);
                    cmd.Parameters.AddWithValue("p_Color", Transmission);
                    cmd.Parameters.AddWithValue("p_FuelType", FuelType);
                    cmd.Parameters.AddWithValue("p_SeatingCapacity", SeatingCapacity);
                    cmd.Parameters.AddWithValue("p_DailyRate", DailyRate);
                    cmd.Parameters.AddWithValue("p_WeeklyRate", WeeklyRate);
                    cmd.Parameters.AddWithValue("p_MonthlyRate", MonthlyRate);
                    cmd.Parameters.AddWithValue("p_v_Status", Status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0; // success
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding vehicle: " + ex.Message);
                return false; // failed
            }
        }
        public static DataTable GetVehicle()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_VehicleFleet", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
