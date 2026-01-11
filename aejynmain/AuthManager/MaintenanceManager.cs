using aejynmain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace aejynmain.AuthManager
{
    internal class MaintenanceManager
    {
        private static string ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        // ==========================
        // LOAD VEHICLES
        // ==========================
        public static List<VehicleModel> GetVehicles()
        {
            List<VehicleModel> vehicles = new List<VehicleModel>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_GetVehicles", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        vehicles.Add(new VehicleModel
                        {
                            VehicleID = dr.GetInt32("VehicleID"),
                            Make = dr.GetString("Make"),
                            Model = dr.GetString("Model"),
                            VehicleYear = dr.GetInt32("VehicleYear"),
                            CategoryName = dr.GetString("CategoryName"),
                            LicensePlate = dr.GetString("LicensePlate"),
                            VehicleStatus = dr.GetString("VehicleStatus")
                        });
                    }
                }
            }

            return vehicles;
        }


        // ==========================
        // SCHEDULE MAINTENANCE (TRANSACTION)
        // ==========================
        public static bool ScheduleMaintenance(
          int vehicleId,
          string maintenanceType,
          string description,
          decimal cost,
          DateTime startDate,
          DateTime endDate
                           )
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand("sp_ScheduleMaintenance", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_VehicleID", vehicleId);
                    cmd.Parameters.AddWithValue("p_MaintenanceType", maintenanceType);
                    cmd.Parameters.AddWithValue("p_Description", description);
                    cmd.Parameters.AddWithValue("p_Cost", cost);
                    cmd.Parameters.AddWithValue("p_StartDate", startDate);
                    cmd.Parameters.AddWithValue("p_EndDate", endDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error scheduling maintenance:\n{ex.Message}",
                    "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static void StartMaintenance(int maintenanceId)
        {
          using var con = new MySqlConnection(ConnectionString);
          using var cmd = new MySqlCommand("sp_StartMaintenance", con);

          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@p_MaintenanceID", maintenanceId);

          con.Open();
          cmd.ExecuteNonQuery();
        }
        

        // ==========================
        // COMPLETE MAINTENANCE
        // ==========================
        public static void CompleteMaintenance(int vehicleId)
        {
            using var con = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand("sp_CompleteMaintenance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_VehicleID", vehicleId);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        // ==========================
        // GET SCHEDULED MAINTENANCE LIST
        // ==========================
        public static List<MaintenanceModel> GetScheduledMaintenance()
        {
            List<MaintenanceModel> list = new List<MaintenanceModel>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_GetScheduledMaintenance", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new MaintenanceModel
                        {
                            MaintenanceID = dr.GetInt32("MaintenanceID"),
                            VehicleID = dr.GetInt32("VehicleID"),
                            VehicleName = dr.GetString("VehicleName"),
                            MaintenanceType = dr.GetString("MaintenanceType"),
                            Description = dr.GetString("Description"),
                            Cost = dr.GetDecimal("Cost"),
                            StartDate = dr.GetDateTime("StartDate"),
                            EndDate = dr.GetDateTime("EndDate"),
                            MaintenanceStatus = dr.GetString("MaintenanceStatus")
                        });
                    }
                }
            }
            return list;
        }
    }
}