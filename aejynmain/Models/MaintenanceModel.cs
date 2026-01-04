using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.Models
{
    internal class MaintenanceModel
    {
        public int MaintenanceID { get; set; }
        public int VehicleID { get; set; }
        public string VehicleName { get; set; } 
        public string MaintenanceType { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MaintenanceStatus { get; set; }
    }
}
