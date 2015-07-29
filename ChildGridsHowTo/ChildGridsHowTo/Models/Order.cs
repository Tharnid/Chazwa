using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChildGridsHowTo.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string OrderType { get; set; }
        [Required]
        public string OrderStatus { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}