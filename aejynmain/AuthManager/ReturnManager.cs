using aejynmain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace aejynmain.AuthManager
{
    internal class ReturnManager
    {
        private static string ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        // Get active rentals as List<Return>
        public static List<Return> GetActiveRentals()
        {
            List<Return> returns = new List<Return>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_GetActiveRentals", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        returns.Add(new Return
                        {
                            RentalID = Convert.ToInt32(dr["RentalID"]),
                            CustomerName = dr["CustomerName"].ToString(),
                            LicensePlate = dr["LicensePlate"].ToString(),
                            Make = dr["Make"].ToString(),
                            Model = dr["Model"].ToString(),
                            PickupMileage = dr["PickupMileage"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PickupMileage"]),
                            PickupDate = Convert.ToDateTime(dr["PickupDate"]),
                            ReturnDate = Convert.ToDateTime(dr["ReturnDate"]),
                            ActualReturnDate = dr["ActualReturnDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["ActualReturnDate"]),
                            RentalStatus = dr["RentalStatus"].ToString()
                        });
                    }
                }
            }

            return returns;
        }

        // Get the base rental total amount saved when the rental was created
        public static decimal GetRentalTotalAmount(int rentalId)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                @"SELECT IFNULL(TotalAmount, 0) FROM tblrentals WHERE RentalID = @RentalID", con))
            {
                cmd.Parameters.AddWithValue("@RentalID", rentalId);
                con.Open();
                object result = cmd.ExecuteScalar();
                return result == null ? 0m : Convert.ToDecimal(result);
            }
        }

        // Return vehicle
        public static void ReturnVehicle(Return ret)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_ReturnVehicle", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Mark all damages for a rental as paid
        public static void MarkDamagesPaid(int rentalId)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_MarkDamagesPaid", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_RentalID", rentalId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void ReturnVehicles(int rentalID, int returnMileage, string fuelLevel, string condition, DateTime actualReturnDate)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_ReturnVehicles", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_RentalID", rentalID);
                cmd.Parameters.AddWithValue("@p_ReturnMileage", returnMileage);
                cmd.Parameters.AddWithValue("@p_ReturnFuelLevel", fuelLevel);
                cmd.Parameters.AddWithValue("@p_ReturnCondition", condition);
                cmd.Parameters.AddWithValue("@p_ActualReturnDate", actualReturnDate);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertDamage(int rentalId, int userId, string description, decimal repairCost)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            using (var cmd = new MySqlCommand("sp_InsertDamage", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_RentalID", rentalId);
                cmd.Parameters.AddWithValue("@p_UserID", userId);
                cmd.Parameters.AddWithValue("@p_Description", description);
                cmd.Parameters.AddWithValue("@p_RepairCost", repairCost);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static decimal GetDailyRate(int rentalId)
        {
            using (var con = new MySqlConnection(ConnectionString))
            using (var cmd = new MySqlCommand("sp_GetDailyRate", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_RentalID", rentalId);
                con.Open();
                var result = cmd.ExecuteScalar();
                return result == null || result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        public static void InsertOrUpdateInvoice(int rentalId, decimal rentalCharges, decimal damageCharges, decimal overdueCharges, decimal fuelCharges, decimal cleaningCharges)
        {
            using var con = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand("sp_InsertOrUpdateInvoice", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_RentalID", rentalId);
            cmd.Parameters.AddWithValue("@p_RentalCharges", rentalCharges);
            cmd.Parameters.AddWithValue("@p_DamageCharges", damageCharges);
            cmd.Parameters.AddWithValue("@p_OverdueCharges", overdueCharges);
            cmd.Parameters.AddWithValue("@p_FuelCharges", fuelCharges);
            cmd.Parameters.AddWithValue("@p_CleaningCharges", cleaningCharges);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        // Save payment when vehicle is returned
        public static void SaveReturnPayment(int rentalId, decimal amount, string paymentMethod, int userId)
        {
            if (amount <= 0) return; // Don't save if amount is 0

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("sp_SaveReturnPayment", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_RentalID", rentalId);
                cmd.Parameters.AddWithValue("p_Amount", amount);
                cmd.Parameters.AddWithValue("p_PaymentMethod", paymentMethod ?? "Cash");
                cmd.Parameters.AddWithValue("p_UserID", userId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update vehicle mileage when returned
        public static void UpdateVehicleMileage(int rentalId, int returnMileage)
        {
            using var con = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand("sp_UpdateVehicleMileage", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_RentalID", rentalId);
            cmd.Parameters.AddWithValue("@p_ReturnMileage", returnMileage);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public static decimal GetDepositPaid(int rentalId)
        {
            using (var con = new MySqlConnection(ConnectionString))
            using (var cmd = new MySqlCommand("sp_GetDepositPaid", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_RentalID", rentalId);
                con.Open();

                var result = cmd.ExecuteScalar();
                return result == null || result == DBNull.Value
                    ? 0m
                    : Convert.ToDecimal(result);
            }
        }

    }
}