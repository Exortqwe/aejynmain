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
            using (MySqlCommand cmd = new MySqlCommand(
                @"UPDATE tbldamages
                  SET Paid = 1
                  WHERE RentalID = @RentalID", con))
            {
                cmd.Parameters.AddWithValue("@RentalID", rentalId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static void ReturnVehicle(int rentalID, int returnMileage, string fuelLevel, string condition, DateTime actualReturnDate)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                @"UPDATE tblrentals
              SET ActualReturnDate=@ActualReturnDate,
                  ReturnMileage=@ReturnMileage,
                  ReturnFuelLevel=@FuelLevel,
                  ReturnCondition=@Condition,
                  RentalStatus='Returned'
              WHERE RentalID=@RentalID", con))
            {
                cmd.Parameters.AddWithValue("@ActualReturnDate", actualReturnDate);
                cmd.Parameters.AddWithValue("@ReturnMileage", returnMileage);
                cmd.Parameters.AddWithValue("@FuelLevel", fuelLevel);
                cmd.Parameters.AddWithValue("@Condition", condition);
                cmd.Parameters.AddWithValue("@RentalID", rentalID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static void InsertDamage(int rentalID, int userID, string description, decimal repairCost)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                @"INSERT INTO tbldamages 
          (RentalID, UserID, Description, `Paid`, RepairCost, DateReported) 
          VALUES (@RentalID, @UserID, @Description, @Paid, @RepairCost, NOW())", con))
            {
                cmd.Parameters.AddWithValue("@RentalID", rentalID);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Paid", false); // unpaid by default
                cmd.Parameters.AddWithValue("@RepairCost", repairCost);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static decimal GetTotalPaid(int rentalId)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                @"SELECT IFNULL(SUM(Amount), 0)
          FROM tblpayments
          WHERE RentalID = @RentalID
          AND (PaymentType = 'Deposit' 
               OR PaymentType LIKE 'Partial%' 
               OR PaymentType LIKE 'Fullpayment%'
               OR PaymentType LIKE 'Full Payment%'
               OR PaymentType = 'Full')
          AND PaymentStatus IN ('Paid', 'Pending')",
                con))
            {
                cmd.Parameters.AddWithValue("@RentalID", rentalId);
                con.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
        public static decimal GetDailyRate(int rentalId)
        {
            decimal dailyRate = 0;

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                @"SELECT vc.DailyRate
          FROM tblrentals r
          INNER JOIN tblvehicles v ON r.VehicleID = v.VehicleID
          INNER JOIN tblvehicle_categories vc ON v.CategoryID = vc.CategoryID
          WHERE r.RentalID = @RentalID", con))
            {
                cmd.Parameters.AddWithValue("@RentalID", rentalId);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                    dailyRate = Convert.ToDecimal(result);
            }

            return dailyRate;
        }
        public static void InsertOrUpdateInvoice(int rentalId, decimal rentalCharges, decimal damageCharges, decimal overdueCharges, decimal fuelCharges)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                @"INSERT INTO tblinvoices (RentalID, RentalCharges, DamageCharges, OverdueCharges, FuelCharges)
          VALUES (@RentalID, @RentalCharges, @DamageCharges, @OverdueCharges, @FuelCharges)
          ON DUPLICATE KEY UPDATE 
              RentalCharges=@RentalCharges, DamageCharges=@DamageCharges, OverdueCharges=@OverdueCharges, FuelCharges=@FuelCharges", con))
            {
                cmd.Parameters.AddWithValue("@RentalID", rentalId);
                cmd.Parameters.AddWithValue("@RentalCharges", rentalCharges);
                cmd.Parameters.AddWithValue("@DamageCharges", damageCharges);
                cmd.Parameters.AddWithValue("@OverdueCharges", overdueCharges);
                cmd.Parameters.AddWithValue("@FuelCharges", fuelCharges);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Save payment when vehicle is returned
        public static void SaveReturnPayment(int rentalId, decimal amount, string paymentMethod, int userId)
        {
            if (amount <= 0) return; // Don't save if amount is 0

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                @"INSERT INTO tblpayments (RentalID, PaymentType, Amount, PaymentMethod, PaymentStatus, PaymentDate)
          VALUES (@RentalID, 'Complete', @Amount, @PaymentMethod, 'Paid', NOW())", con))
            {
                cmd.Parameters.AddWithValue("@RentalID", rentalId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod ?? "Cash");

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update vehicle mileage when returned
        public static void UpdateVehicleMileage(int rentalId, int returnMileage)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                @"UPDATE tblvehicles v
          INNER JOIN tblrentals r ON v.VehicleID = r.VehicleID
          SET v.Mileage = @ReturnMileage,
              v.VehicleStatus = 'Available'
          WHERE r.RentalID = @RentalID", con))
            {
                cmd.Parameters.AddWithValue("@ReturnMileage", returnMileage);
                cmd.Parameters.AddWithValue("@RentalID", rentalId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}