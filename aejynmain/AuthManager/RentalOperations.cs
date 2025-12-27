using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.AuthManager
{
    internal class RentalOperations
    {
        public class Customer
        {
            public string FullName { get; set; }
            public string LicenseNumber { get; set; }
            public string ContactNumber { get; set; }
            public string Address { get; set; }
        }
        public class CustomerService
        {
            public static Customer SearchCustomer(string keyword)
            {
                DataTable dt = AddCustomer.GetCustomers();

                foreach (DataRow dr in dt.Rows)
                {
                    string fullName = dr["FirstName"] + " " + dr["LastName"];

                    if (fullName.Contains(keyword) ||
                        dr["LicenseNumber"].ToString().Contains(keyword))
                    {
                        return new Customer
                        {
                            FullName = fullName,
                            LicenseNumber = dr["LicenseNumber"].ToString(),
                            ContactNumber = dr["ContactNumber"].ToString(),
                            Address = dr["Address"].ToString()
                        };
                    }
                }

                return null;
            }
            public class RentalResult
            {
                public int TotalDays { get; set; }
                public string RateType { get; set; }
                public decimal TotalPrice { get; set; }
            }
            public class RentalCalculator
            {
                public static RentalResult Calculate(
                    DateTime pickup,
                    DateTime returndate,
                    decimal dailyRate,
                    decimal weeklyRate,
                    decimal monthlyRate)
                {
                    TimeSpan diff = returndate - pickup;
                    int totalDays = diff.Days;

                    if (totalDays <= 0)
                        throw new Exception("Invalid date range");

                    decimal total = 0;
                    string rateType = "";

                    if (totalDays >= 30)
                    {
                        int months = totalDays / 30;
                        total = months * monthlyRate;
                        rateType = "Monthly";
                    }
                    else if (totalDays >= 7)
                    {
                        int weeks = totalDays / 7;
                        total = weeks * weeklyRate;
                        rateType = "Weekly";
                    }
                    else
                    {
                        total = totalDays * dailyRate;
                        rateType = "Daily";
                    }

                    return new RentalResult
                    {
                        TotalDays = totalDays,
                        RateType = rateType,
                        TotalPrice = total
                    };
                }
            }
        }
    }
}
