using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.Models
{
    internal class Dashboard
    {
        
        public int TotalVehicles { get; set; }
        public int AvailableVehicles { get; set; }
        public int ActiveRentals { get; set; }
        public int Reservation { get; set; }
        public int Overdue { get; set; }
        public decimal RevenueToday { get; set; }
    }
}

