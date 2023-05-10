using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebECApp.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string ProductID { get; set; }
        public string Name { get; set; }
        public string UserID { get; set; }
        public string DateTime { get; set; }
    }
}
