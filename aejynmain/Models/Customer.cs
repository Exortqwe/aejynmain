using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aejynmain.Models;

namespace aejynmain.Models
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType Type { get; set; } = CustomerType.Individual;
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateRegistered { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public string CompanyName { get; set; }
    }
    public enum CustomerType
    {  
        Individual,
        Corporate,
        Frequent,
        Blacklisted,
        WalkIn
    }
}
