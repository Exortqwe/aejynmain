using aejynmain.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.AuthManager
{
    internal class ReservationManager
    {
        private static string ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        public static void SaveReservation(Reservation reservation)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_SaveReservation", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_UserID", User.UserID);
                    cmd.Parameters.AddWithValue("p_CustomerID", reservation.CustomerID);
                    cmd.Parameters.AddWithValue("p_VehicleID", reservation.VehicleID);
                    cmd.Parameters.AddWithValue("p_PickUpDate", reservation.PickUpDate);
                    cmd.Parameters.AddWithValue("p_ReturnDate", reservation.ReturnDate);
                    cmd.Parameters.AddWithValue("p_ReservationStatus", reservation.Status);
                    cmd.Parameters.AddWithValue("p_TotalAmount", reservation.TotalAmount);
                    cmd.Parameters.AddWithValue("p_PaymentType", reservation.Payment.PaymentType);
                    cmd.Parameters.AddWithValue("p_Amount", reservation.Payment.Amount);
                    cmd.Parameters.AddWithValue("p_PaymentMethod", reservation.Payment.PaymentMethod);
                    cmd.Parameters.AddWithValue("p_PaymentStatus", reservation.Payment.PaymentStatus);

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
                            image_path = dr["image_path"].ToString(),
                            Features = dr["Features"].ToString(),
                            Status = dr["VehicleStatus"].ToString()
                        });
                    }
                }
            }
            return vehicles;
        }
    }
}
