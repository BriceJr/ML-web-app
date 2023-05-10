using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebECApp.Models
{
    public class Return
    {
        public int ReturnID { get; set; }
        public string ProductName { get; set; }
        public string DatePurchased { get; set; }
        public DateTime TimeStamp { get; set; }
        public string UserId { get; set; }
        public string Reason { get; set; }
    }
}
