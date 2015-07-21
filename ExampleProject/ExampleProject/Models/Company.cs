using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExampleProject.Models
{
    [Table("Company")]
    public class Company
    {

        public enum kCompanyType : int { Live = 1, Test = 2 }

        [Key, Column(Order = 0)]
        [Required]
        [Display(Name = "CompanyId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "TenantId")]
        public int TenantId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Country")]
        [StringLength(2)]
        public string CountryCode { get; set; }

        [Display(Name = "Currency")]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        [Display(Name = "Type")]
        [StringLength(1)]
        public string CompanyType { get; set; }


        public kCompanyType CompanyTypeCode
        {
            get
            {
                if (this.CompanyType == "L")
                {
                    return kCompanyType.Live;
                }
                else
                {
                    return kCompanyType.Test;
                }

            }
        }

    }
}