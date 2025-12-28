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
    internal class RentalOperations
    {
        private static string ConnectionString ="datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";

        public static void SaveRental(
            int customerId,
            int vehicleId,
            DateTime pickup,
            DateTime ret,
            decimal totalAmount,
            string status)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand("sp_SaveRental", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_CustomerID", customerId);
                    cmd.Parameters.AddWithValue("p_VehicleID", vehicleId);
                    cmd.Parameters.AddWithValue("p_PickUpDate", pickup);
                    cmd.Parameters.AddWithValue("p_ReturnDate", ret);
                    cmd.Parameters.AddWithValue("p_r_Status", status);
                    cmd.Parameters.AddWithValue("p_TotalAmount", totalAmount);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
    

