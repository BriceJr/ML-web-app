using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebECApp.Models
{
    public class Product
    {
        //creating a class with different data properties
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string ProductImage { get; set; }
        public string Image_2 { get; set; }
        public string Image_3 { get; set; }
        public string Image_4 { get; set; }
        public string Image_5 { get; set; }
        public string Image_6 { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
