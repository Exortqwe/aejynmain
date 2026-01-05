using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.Models
{
    internal class Vehicle
    {
        public int VehicleID { get; set; }
        public string CategoryName { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public string VIN { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public int SeatingCapacity { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal DailyRate { get; set; }
        public decimal WeeklyRate { get; set; }
        public decimal MonthlyRate { get; set; }
        public string Status { get; set; }  
        public string Features { get; set; }      
        public string image_path { get; set; }
        public string FuelLevel { get; set; }
        public string InitialCondition { get; set; }
        public string ReturnCondition { get; set; }
    }
}
