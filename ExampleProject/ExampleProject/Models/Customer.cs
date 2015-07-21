using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleProject.Models
{
    [Table("Customer")]
    public class Customer
    {
        // Keys

        [Key, Column(Order = 0)]
        [Required]
        [Display(Name = "Company")]
        public int CompanyId { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        [Display(Name = "Customer")]
        [StringLength(30)]
        public string CustomerId { get; set; }

        // End Keys

        [Display(Name = "Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Address 1")]
        [StringLength(100)]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        [StringLength(100)]
        public string Address2 { get; set; }

        [Display(Name = "Address 3")]
        [StringLength(100)]
        public string Address3 { get; set; }

        [Display(Name = "Address 4")]
        [StringLength(100)]
        public string Address4 { get; set; }

        [Display(Name = "City")]
        [StringLength(100)]
        public string City { get; set; }

        [Display(Name = "County")]
        [StringLength(100)]
        public string County { get; set; }

        [Display(Name = "State")]
        [StringLength(10)]
        public string StateCode { get; set; }

        [Display(Name = "Country")]
        [StringLength(2)]
        public string CountryCode { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Display(Name = "Remote")]
        [StringLength(100)]
        public string RemoteId { get; set; }

        [Display(Name = "VariationId")]
        public long VariationId { get; set; }


        // Children

        public virtual ICollection<ShipTo> ShipTo { get; set; }
        // public virtual ICollection<CustomerClass> CustomerClass { get; set; }
    }
}