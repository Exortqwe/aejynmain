using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace aejynmain.AuthManager
{
    public class ReportManager
    {
        public static string ConnectionString { get; set; } = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        public ReportManager()
        {
            // Constructor is kept for backward compatibility
        }

        public static (double UtilizationRate, int TotalRentalDays, int TotalAvailableDays) GetFleetUtilizationRate()
        {
            double utilizationRate = 0;
            int totalRentalDays = 0;
            int totalAvailableDays = 0;

            using var conn = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand("sp_GetFleetUtilizationRate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("@p_UtilizationRate", MySqlDbType.Double) { Direction = ParameterDirection.Output });
            cmd.Parameters.Add(new MySqlParameter("@p_TotalRentalDays", MySqlDbType.Int32) { Direction = ParameterDirection.Output });
            cmd.Parameters.Add(new MySqlParameter("@p_TotalAvailableDays", MySqlDbType.Int32) { Direction = ParameterDirection.Output });

            conn.Open();
            cmd.ExecuteNonQuery();

            utilizationRate = Convert.ToDouble(cmd.Parameters["@p_UtilizationRate"].Value);
            totalRentalDays = Convert.ToInt32(cmd.Parameters["@p_TotalRentalDays"].Value);
            totalAvailableDays = Convert.ToInt32(cmd.Parameters["@p_TotalAvailableDays"].Value);

            return (utilizationRate, totalRentalDays, totalAvailableDays);
        }
        public static decimal GetRevenuePerVehicle()
        {
            using var conn = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand("sp_GetRevenuePerVehicle", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@p_RevenuePerVehicle", MySqlDbType.Decimal) { Direction = ParameterDirection.Output });
            conn.Open();
            cmd.ExecuteNonQuery();
            return Convert.ToDecimal(cmd.Parameters["@p_RevenuePerVehicle"].Value);
        }

        public static decimal GetAverageRentalRate()
        {
            using var conn = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand("sp_GetAverageRentalRate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@p_AvgRentalRate", MySqlDbType.Decimal)
            { Direction = ParameterDirection.Output });
            conn.Open();
            cmd.ExecuteNonQuery();
            return Convert.ToDecimal(cmd.Parameters["@p_AvgRentalRate"].Value);
        }
        public static double GetAverageDelayHours()
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();

            using var cmd = new MySqlCommand("sp_GetAverageDelayHours", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            var param = new MySqlParameter("p_AvgDelayHours", MySqlDbType.Double);
            param.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            return Convert.ToDouble(param.Value);
        }
        public static int GetTotalOverdueCount()
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();

            using var cmd = new MySqlCommand("sp_GetTotalOverdueCount", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            var param = new MySqlParameter("p_TotalOverdue", MySqlDbType.Int32);
            param.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            return Convert.ToInt32(param.Value);
        }

        public DataTable GetVehicleAvailabilityStatus()
        {
            DataTable dt = new DataTable();
            using var conn = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand("sp_GetVehicleAvailabilityStatus", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            using var da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable GetPopularVehicles()
        {
            DataTable dt = new DataTable();
            using var conn = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand("sp_GetPopularVehicles", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            using var da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable GetUpcomingRentalSchedule()
        {
            DataTable dt = new DataTable();
            using var conn = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand("sp_GetUpcomingRentalSchedule", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            using var da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
