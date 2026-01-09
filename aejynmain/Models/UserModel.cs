using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }   // ✅
        public string Address { get; set; }        // ✅
        public string Role { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
