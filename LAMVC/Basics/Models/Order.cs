using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Basics.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
    }
}