using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.HelperMethod
{
    internal class RentalCalculator
    {
        public static decimal CalculateTotal(
       DateTime pickup,
       DateTime ret,
       decimal hourlyRate,
       decimal dailyRate,
       decimal weeklyRate,
       decimal monthlyRate,
       out string rateLabel,
       out string durationLabel)
        {
            double hours = (ret - pickup).TotalHours;
            if (hours <= 0) hours = 1;

            int days = (int)Math.Ceiling(hours / 24.0);
            decimal total;

            if (hours < 24)
            {
                total = (decimal)Math.Ceiling(hours) * hourlyRate;
                rateLabel = "Hourly Rate";
                durationLabel = $"{Math.Ceiling(hours)} hrs";
            }
            else if (days >= 30)
            {
                int months = days / 30;
                int remainingDays = days % 30;
                total = (months * monthlyRate) + (remainingDays * dailyRate);
                rateLabel = "Monthly Rate";
                durationLabel = days.ToString();
            }
            else if (days >= 7)
            {
                int weeks = days / 7;
                int remainingDays = days % 7;
                total = (weeks * weeklyRate) + (remainingDays * dailyRate);
                rateLabel = "Weekly Rate";
                durationLabel = days.ToString();
            }
            else
            {
                total = days * dailyRate;
                rateLabel = "Daily Rate";
                durationLabel = days.ToString();
            }

            return total;
        }
    }
}
