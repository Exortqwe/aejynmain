using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace aejynmain.AuthManager
{
    internal class Dashboard
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";
        
        // PARA SA PANEL CARDS NI SIYA
        public static int TotalVehicles()
        {
            return GetCount("sp_TotalVehicles");
        }
        public static int AvailableVehicles()
        {
            return GetCount("sp_AvailableVehicles");
        }
        public static int ActiveRentals()
        {
            return GetCount("sp_ActiveRentals");
        }
        public static int LateReturn()
        {
            return GetCount("sp_LateReturnRentals");
        }
        public static decimal RevenueToday()
        {
            return GetAmount("sp_RevenueToday");
        }

        // PARA SA CHARTS NI SIYA

        // BAR CHART
        public static DataTable RevenueByDate()
        {
            return GetTable("sp_RevenueByDate");
        }
        //PIE CHART
        public static DataTable VehicleStatus()
        {
            return GetTable("sp_VehicleStatus");
        }

        // HELPER METHODS

        private static int GetCount(string sp)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(sp, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        private static decimal GetAmount(string sp)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(sp, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
        private static DataTable GetTable(string sp)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(sp, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
