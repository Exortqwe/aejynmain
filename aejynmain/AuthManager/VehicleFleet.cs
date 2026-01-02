using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using aejynmain.Models;

namespace aejynmain.AuthManager
{
    internal class VehicleFleet
    {
        private static string connectionString =
            "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        public static List<Vehicle> GetVehicleList()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_GetVehicles", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        vehicles.Add(new Vehicle
                        {
                            VehicleID = Convert.ToInt32(dr["VehicleID"]),
                            CategoryName = dr["CategoryName"].ToString(),
                            Make = dr["Make"].ToString(),
                            Model = dr["Model"].ToString(),
                            LicensePlate = dr["LicensePlate"].ToString(),
                            Mileage = Convert.ToInt32(dr["Mileage"]),
                            Year = Convert.ToInt32(dr["VehicleYear"]),
                            VIN = dr["VIN"].ToString(),
                            Color = dr["Color"].ToString(),
                            Transmission = dr["Transmission"].ToString(),
                            FuelType = dr["FuelType"].ToString(),
                            SeatingCapacity = Convert.ToInt32(dr["SeatingCapacity"]),
                            HourlyRate = Convert.ToDecimal(dr["HourlyRate"]),
                            DailyRate = Convert.ToDecimal(dr["DailyRate"]),
                            WeeklyRate = Convert.ToDecimal(dr["WeeklyRate"]),
                            MonthlyRate = Convert.ToDecimal(dr["MonthlyRate"]),
                            Features = dr["Features"].ToString(),
                            Status = dr["VehicleStatus"].ToString(),
                            image_path = dr["image_path"].ToString()
                        });
                    }
                }
            }
            return vehicles;
        }
        public static bool AddVehicle(Vehicle v)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_AddVehicle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_CategoryName", v.CategoryName);
                    cmd.Parameters.AddWithValue("p_HourlyRate", v.HourlyRate);
                    cmd.Parameters.AddWithValue("p_DailyRate", v.DailyRate);
                    cmd.Parameters.AddWithValue("p_WeeklyRate", v.WeeklyRate);
                    cmd.Parameters.AddWithValue("p_MonthlyRate", v.MonthlyRate);
                    cmd.Parameters.AddWithValue("p_Make", v.Make);
                    cmd.Parameters.AddWithValue("p_Model", v.Model);
                    cmd.Parameters.AddWithValue("p_LicensePlate", v.LicensePlate);
                    cmd.Parameters.AddWithValue("p_Mileage", v.Mileage);
                    cmd.Parameters.AddWithValue("p_VehicleYear", v.Year);
                    cmd.Parameters.AddWithValue("p_VIN", v.VIN);
                    cmd.Parameters.AddWithValue("p_Color", v.Color);
                    cmd.Parameters.AddWithValue("p_Transmission", v.Transmission);
                    cmd.Parameters.AddWithValue("p_FuelType", v.FuelType);
                    cmd.Parameters.AddWithValue("p_SeatingCapacity", v.SeatingCapacity);
                    cmd.Parameters.AddWithValue("p_Features", v.Features);
                    cmd.Parameters.AddWithValue("p_VehicleStatus", v.Status);
                    cmd.Parameters.AddWithValue("p_image_path", v.image_path);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding vehicle: " + ex.Message);
                return false;
            }
        }
        public static bool DeleteVehicle(int vehicleID)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tblvehicles WHERE VehicleID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", vehicleID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateVehicle(int vehicleID, string columnName, object newValue)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Create the SQL query to update the column of the vehicle based on the VehicleID
                    string query = $"UPDATE tblvehicles SET {columnName} = @NewValue WHERE VehicleID = @VehicleID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add the parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@VehicleID", vehicleID);
                        cmd.Parameters.AddWithValue("@NewValue", newValue ?? DBNull.Value);

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
                MessageBox.Show(ex.Message, "Error Updating Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

    
