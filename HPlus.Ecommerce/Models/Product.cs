using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HPlus.Ecommerce.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal FullPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public int PercentOff { get; set; }
        public string ImagePath { get; set; }
        public int StarRating { get; set; }

    }
}