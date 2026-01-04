using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.HelperMethod
{
    internal class FuelHelper
    {
        public static decimal CalculateFuelCharge(string fuelLevel)
        {
            switch (fuelLevel)
            {
                case "Full": return 0;
                case "3/4": return 300;
                case "1/2": return 600;
                case "1/4": return 900;
                case "Empty": return 1200;
                default: return 0;
            }
        }
    }
}
