using aejynmain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace aejynmain.AuthManager
{
    internal class RentalOperation
    {
        private static string ConnectionString ="datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        public static void SaveRental(Rental rental)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_SaveRental", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_CustomerID", rental.CustomerID);
                    cmd.Parameters.AddWithValue("p_VehicleID", rental.VehicleID);
                    cmd.Parameters.AddWithValue("p_PickUpDate", rental.PickUpDate);
                    cmd.Parameters.AddWithValue("p_ReturnDate", rental.ReturnDate);
                    cmd.Parameters.AddWithValue("p_r_Status", rental.Status);
                    cmd.Parameters.AddWithValue("p_TotalAmount", rental.TotalAmount);
                    cmd.Parameters.AddWithValue("p_PaymentType", rental.Payment.PaymentType);
                    cmd.Parameters.AddWithValue("p_Amount", rental.Payment.Amount);
                    cmd.Parameters.AddWithValue("p_PaymentMethod", rental.Payment.PaymentMethod);
                    cmd.Parameters.AddWithValue("p_PaymentStatus", rental.Payment.PaymentStatus);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<Vehicle> GetAvailableVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_GetAvailableVehicles", con))
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
                            Year = Convert.ToInt32(dr["Year"]),
                            VIN = dr["VIN"].ToString(),
                            Color = dr["Color"].ToString(),
                            Transmission = dr["Transmission"].ToString(),
                            FuelType = dr["FuelType"].ToString(),
                            SeatingCapacity = Convert.ToInt32(dr["SeatingCapacity"]),
                            HourlyRate = Convert.ToDecimal(dr["HourlyRate"]),
                            DailyRate = Convert.ToDecimal(dr["DailyRate"]),
                            WeeklyRate = Convert.ToDecimal(dr["WeeklyRate"]),
                            MonthlyRate = Convert.ToDecimal(dr["MonthlyRate"]),
                            Status = dr["Status"].ToString()
                        });
                    }
                }
            }
            return vehicles;
        }
    }
}
    

