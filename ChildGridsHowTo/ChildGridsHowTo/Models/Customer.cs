using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Owin.BuilderProperties;

namespace ChildGridsHowTo.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Order> Order { get; set; } 
    }
}