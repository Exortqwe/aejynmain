using aejynmain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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
            using (MySqlCommand cmd = new MySqlCommand(@"
                SELECT 
                    v.VehicleID,
                    v.Make,
                    v.Model,
                    v.VehicleYear,
                    vc.CategoryName,
                    v.LicensePlate,
                    v.VehicleStatus
                FROM tblvehicles v
                INNER JOIN tblvehicle_categories vc ON v.CategoryID = vc.CategoryID
            ", con))
            {
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
            DateTime endDate,
            out string errorMessage)
        {
            errorMessage = string.Empty;

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                MySqlTransaction tran = con.BeginTransaction();

                try
                {
                    // INSERT MAINTENANCE
                    using (MySqlCommand cmd1 = new MySqlCommand(@"
                        INSERT INTO tblmaintenance_records
                        (
                            VehicleID,
                            MaintenanceType,
                            Description,
                            Cost,
                            StartDate,
                            EndDate,
                            MaintenanceStatus
                        )
                        VALUES
                        (
                            @VehicleID,
                            @MaintenanceType,
                            @Description,
                            @Cost,
                            @StartDate,
                            @EndDate,
                            'Scheduled'
                        )
                    ", con, tran))
                    {
                        cmd1.Parameters.AddWithValue("@VehicleID", vehicleId);
                        cmd1.Parameters.AddWithValue("@MaintenanceType", maintenanceType);
                        cmd1.Parameters.AddWithValue("@Description", description);
                        cmd1.Parameters.AddWithValue("@Cost", cost);
                        cmd1.Parameters.AddWithValue("@StartDate", startDate);
                        cmd1.Parameters.AddWithValue("@EndDate", endDate);
                        cmd1.ExecuteNonQuery();
                    }

                    // UPDATE VEHICLE STATUS
                    using (MySqlCommand cmd2 = new MySqlCommand(@"
                        UPDATE tblvehicles
                        SET VehicleStatus = 'Under Maintenance'
                        WHERE VehicleID = @VehicleID
                    ", con, tran))
                    {
                        cmd2.Parameters.AddWithValue("@VehicleID", vehicleId);
                        cmd2.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    errorMessage = ex.Message;
                    return false;
                }
            }
        }

        // ==========================
        // COMPLETE MAINTENANCE
        // ==========================
        public static void CompleteMaintenance(int vehicleId)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                MySqlTransaction tran = con.BeginTransaction();

                try
                {
                    using (MySqlCommand cmd1 = new MySqlCommand(@"
                        UPDATE tblmaintenance_records
                        SET MaintenanceStatus = 'Completed'
                        WHERE VehicleID = @VehicleID
                          AND MaintenanceStatus = 'Ongoing'
                    ", con, tran))
                    {
                        cmd1.Parameters.AddWithValue("@VehicleID", vehicleId);
                        cmd1.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd2 = new MySqlCommand(@"
                        UPDATE tblvehicles
                        SET VehicleStatus = 'Available'
                        WHERE VehicleID = @VehicleID
                    ", con, tran))
                    {
                        cmd2.Parameters.AddWithValue("@VehicleID", vehicleId);
                        cmd2.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    // consider logging the error here
                }
            }
        }

        // ==========================
        // GET SCHEDULED MAINTENANCE LIST
        // ==========================
        public static List<MaintenanceModel> GetScheduledMaintenance()
        {
            List<MaintenanceModel> list = new List<MaintenanceModel>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(@"
                SELECT 
                    m.MaintenanceID, 
                    m.VehicleID,
                    CONCAT(v.Make, ' ', v.Model) AS VehicleName,
                    m.MaintenanceType, 
                    m.Description, 
                    m.Cost,
                    m.StartDate, 
                    m.EndDate, 
                    m.MaintenanceStatus
                FROM tblmaintenance_records m
                INNER JOIN tblvehicles v ON m.VehicleID = v.VehicleID
            ", con))
            {
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