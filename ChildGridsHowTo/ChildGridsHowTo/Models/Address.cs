using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChildGridsHowTo.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int AddressId { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PostalCode { get; set; }
        public string AddressType { get; set; }
        [Required]
        public int CustomerId { get; set; }

    }
}