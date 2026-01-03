using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.Models
{
    internal class Reservation
    {
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public Payment Payment { get; set; }
        public int PickupMileage { get; set; }
    }
}
