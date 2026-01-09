using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace aejynmain.AuthManager
{
    public class ReportManager
    {
        private static string _connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";
        
        public static string ConnectionString 
        { 
            get => _connectionString;
            set => _connectionString = value ?? throw new ArgumentNullException(nameof(value));
        }

        public ReportManager()
        {
            // Constructor is kept for backward compatibility
        }

        public (double UtilizationRate, int TotalRentalDays, int TotalAvailableDays) GetFleetUtilizationRate()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                
                // Get total available days (number of available vehicles * number of days in current month)
                string query = @"
                    SELECT 
                        (SELECT COUNT(*) FROM tblvehicles WHERE VehicleStatus = 'Available') as total_available_vehicles,
                        DAY(LAST_DAY(CURRENT_DATE())) as days_in_month";
                
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int totalAvailableVehicles = reader.GetInt32("total_available_vehicles");
                        int daysInMonth = reader.GetInt32("days_in_month");
                        int totalAvailableDays = totalAvailableVehicles * daysInMonth;

                        // Get total rental days for current month
                        reader.Close();
                        query = @"
                            SELECT IFNULL(SUM(DATEDIFF(
                                LEAST(r.ReturnDate, LAST_DAY(CURRENT_DATE())), 
                                GREATEST(r.PickupDate, DATE_FORMAT(CURRENT_DATE(), '%Y-%m-01'))
                            ) + 1), 0) as total_rental_days
                            FROM tblrentals r
                            WHERE MONTH(r.PickupDate) = MONTH(CURRENT_DATE())
                            AND YEAR(r.PickupDate) = YEAR(CURRENT_DATE())";

                        cmd.CommandText = query;
                        int totalRentalDays = Convert.ToInt32(cmd.ExecuteScalar());

                        // Calculate utilization rate
                        double utilizationRate = totalAvailableDays > 0 ? 
                            (totalRentalDays / (double)totalAvailableDays) * 100 : 0;
                            

                        return (utilizationRate, totalRentalDays, totalAvailableDays);
                    }
                    return (0, 0, 0);
                }
            }
        }

        public decimal GetRevenuePerVehicle()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                
                // Get total revenue for current month from invoices
                string query = @"
                    SELECT IFNULL(SUM(i.TotalAmount), 0) as total_revenue
                    FROM tblinvoices i
                    INNER JOIN tblrentals r ON i.RentalID = r.RentalID
                    WHERE MONTH(r.PickupDate) = MONTH(CURRENT_DATE())
                    AND YEAR(r.PickupDate) = YEAR(CURRENT_DATE())";
                
                using (var cmd = new MySqlCommand(query, conn))
                {
                    decimal totalRevenue = Convert.ToDecimal(cmd.ExecuteScalar());
                    
                    // Get number of available vehicles
                    query = "SELECT COUNT(*) FROM tblvehicles WHERE VehicleStatus = 'Available'";
                    cmd.CommandText = query;
                    int totalVehicles = Convert.ToInt32(cmd.ExecuteScalar());
                    
                    // Calculate revenue per vehicle
                    return totalVehicles > 0 ? totalRevenue / totalVehicles : 0;
                }
            }
        }

        public decimal GetAverageRentalRate()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                
                // Get average daily rate for current month
                string query = @"
                    SELECT IFNULL(AVG(vc.DailyRate), 0) as avg_rental_rate
                    FROM tblrentals r
                    INNER JOIN tblvehicles v ON r.VehicleID = v.VehicleID
                    INNER JOIN tblvehicle_categories vc ON v.CategoryID = vc.CategoryID
                    WHERE MONTH(r.PickupDate) = MONTH(CURRENT_DATE())
                    AND YEAR(r.PickupDate) = YEAR(CURRENT_DATE())";
                
                using (var cmd = new MySqlCommand(query, conn))
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

        public int GetOverdueRentalsCount()
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();

            string sql = @"
        SELECT
            (
                -- Returned late
                SELECT COUNT(*)
                FROM tblrental r
                WHERE r.Status = 'Returned'
                  AND r.ReturnDate IS NOT NULL
                  AND r.ActualReturnDate IS NOT NULL
                  AND r.ActualReturnDate > r.ReturnDate
            ) +
            (
                -- Currently overdue (not yet returned and beyond planned return)
                SELECT COUNT(*)
                FROM tblrental r
                WHERE r.Status NOT IN ('Returned','Cancelled')
                  AND r.ReturnDate IS NOT NULL
                  AND r.ReturnDate < @now
            ) AS overdue_count;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@now", MySqlDbType.DateTime).Value = DateTime.Now;
            object result = cmd.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        public double GetAverageDelayHours()
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();

            string sql = @"
        SELECT AVG(TIMESTAMPDIFF(HOUR, r.ReturnDate, r.ActualReturnDate))
        FROM tblrental r
        WHERE r.Status = 'Returned'
          AND r.ReturnDate IS NOT NULL
          AND r.ActualReturnDate IS NOT NULL
          AND r.ActualReturnDate > r.ReturnDate;";

            using var cmd = new MySqlCommand(sql, conn);
            object avg = cmd.ExecuteScalar();
            return (avg == null || avg == DBNull.Value) ? 0.0 : Convert.ToDouble(avg);
        }

        public DataTable GetVehiclesByCategory()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            using (var cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"
                    SELECT 
                        vc.CategoryName as 'Category',
                        COUNT(v.VehicleID) as 'TotalVehicles'
                    FROM tblvehicle_categories vc
                    LEFT JOIN tblvehicles v ON vc.CategoryID = v.CategoryID
                    GROUP BY vc.CategoryName";

                DataTable dt = new DataTable();
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }

        public DataTable GetVehicleAvailabilityStatus()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            using (var cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"
            SELECT 
                vc.CategoryName as 'Category',
                SUM(CASE WHEN v.VehicleStatus = 'Available' THEN 1 ELSE 0 END) as 'Available',
                SUM(CASE WHEN v.VehicleStatus = 'Rented' THEN 1 ELSE 0 END) as 'Rented',
                SUM(CASE WHEN v.VehicleStatus = 'Reserved' THEN 1 ELSE 0 END) as 'Reserved',
                SUM(CASE WHEN v.VehicleStatus = 'Under Maintenance' OR v.VehicleStatus = 'Maintenance' THEN 1 ELSE 0 END) as 'Maintenance',
                COUNT(*) as 'Total'
            FROM tblvehicles v
            INNER JOIN tblvehicle_categories vc ON v.CategoryID = vc.CategoryID
            GROUP BY vc.CategoryName
            
            UNION ALL
            
            SELECT 
                'Total' as 'Category',
                SUM(CASE WHEN v.VehicleStatus = 'Available' THEN 1 ELSE 0 END) as 'Available',
                SUM(CASE WHEN v.VehicleStatus = 'Rented' THEN 1 ELSE 0 END) as 'Rented',
                SUM(CASE WHEN v.VehicleStatus = 'Reserved' THEN 1 ELSE 0 END) as 'Reserved',
                SUM(CASE WHEN v.VehicleStatus = 'Under Maintenance' OR v.VehicleStatus = 'Maintenance' THEN 1 ELSE 0 END) as 'Maintenance',
                COUNT(*) as 'Total'
            FROM tblvehicles v";

                DataTable dt = new DataTable();
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }

        public DataTable GetVehiclesUnderMaintenance()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            using (var cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"
                    SELECT 
                        v.VehicleID as 'VehicleID',
                        vc.CategoryName as 'Category',
                        v.Model as 'Model',
                        v.PlateNumber as 'PlateNumber',
                        v.LastMaintenanceDate as 'LastMaintenance',
                        v.NextMaintenanceDate as 'NextMaintenance'
                    FROM tblvehicles v
                    INNER JOIN tblvehicle_categories vc ON v.CategoryID = vc.CategoryID
                    WHERE v.VehicleStatus = 'Maintenance'
                    ORDER BY v.NextMaintenanceDate ASC";

                DataTable dt = new DataTable();
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }
        public DataTable GetPopularVehicles()
        {
            using (var conn = new MySqlConnection(ConnectionString))
            using (var cmd = new MySqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"
            SELECT 
                v.Model,
                vc.CategoryName as Category,
                COUNT(r.RentalID) as RentalCount,
                ROUND((COUNT(r.RentalID) * 100.0) / 
                    (SELECT COUNT(*) FROM tblrentals), 2) as RentalPercentage
            FROM tblvehicles v
            INNER JOIN tblvehicle_categories vc ON v.CategoryID = vc.CategoryID
            LEFT JOIN tblrentals r ON v.VehicleID = r.VehicleID
            GROUP BY v.VehicleID, v.Model, vc.CategoryName
            ORDER BY RentalCount DESC
            LIMIT 10";

                DataTable dt = new DataTable();
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }
        public DataTable GetUpcomingRentalSchedule()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EventStatus");
            dt.Columns.Add("Vehicle");
            dt.Columns.Add("Time");
            dt.Columns.Add("Duration");

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();

                string query = @"
            -- Upcoming pickups from reservations
            SELECT 
                'Pickup' AS EventStatus,
                v.Model AS Vehicle,
                r.PickupDate AS Time,
                DATEDIFF(r.ReturnDate, r.PickupDate) AS Duration
            FROM tblReservations r
            INNER JOIN tblVehicles v ON r.VehicleID = v.VehicleID
            WHERE r.PickupDate >= NOW() 
              AND r.ReservationStatus = 'Reserved'

            UNION ALL

            -- Upcoming returns from rentals
            SELECT 
                'Return' AS EventStatus,
                v.Model AS Vehicle,
                re.ReturnDate AS Time,
                DATEDIFF(re.ReturnDate, re.PickupDate) AS Duration
            FROM tblRentals re
            INNER JOIN tblVehicles v ON re.VehicleID = v.VehicleID
            WHERE re.ReturnDate >= NOW()
              AND re.RentalStatus NOT IN ('Returned','Cancelled')

            ORDER BY Time ASC;
        ";

                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
