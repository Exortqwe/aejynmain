using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.Models
{
    internal class Payment
    {
        
        public int PaymentID { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentMethod { get; set; }
    }
}

