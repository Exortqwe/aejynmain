using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using aejynmain.Models;

namespace aejynmain.AuthManager
{
    internal class DashboardService
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        // Return Dashboard object with all counts
        public static Dashboard GetDashboardData()
        {
            return new Dashboard
            {
                TotalVehicles = GetCount("sp_TotalVehicles"),
                AvailableVehicles = GetCount("sp_AvailableVehicles"),
                ActiveRentals = GetCount("sp_ActiveRentals"),
                Reservation = GetCount("sp_ReservationCount"),
                LateReturn = GetCount("sp_LateReturnRentals"),
                RevenueToday = GetRevenueToday()
            };
        }

        // Get revenue today including return payments
        private static decimal GetRevenueToday()
        {
            try
            {
                // Try direct query first to include all payments from today including return payments
                string query = @"
                    SELECT COALESCE(SUM(Amount), 0) 
                    FROM tblpayments 
                    WHERE DATE(PaymentDate) = CURDATE() 
                    AND PaymentStatus = 'Paid'";

                using var conn = new MySqlConnection(connectionString);
                using var cmd = new MySqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
            }
            catch
            {
                // If direct query fails, fall back to stored procedure
                return GetAmount("sp_RevenueToday");
            }

            return 0;
        }

        // Chart methods
        public static DataTable RevenueByDate()
        {
            return GetTable("sp_RevenueByDate");
        }

        public static DataTable VehicleStatus()
        {
            // Direct query to include all vehicle statuses including Reserved
            string query = "SELECT VehicleStatus AS VehicleStatus, COUNT(*) AS total FROM tblvehicles GROUP BY VehicleStatus";
            
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            using var da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Helper methods
        private static int GetCount(string sp)
        {
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private static decimal GetAmount(string sp)
        {
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        private static DataTable GetTable(string sp)
        {
            using var conn = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            using var da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}