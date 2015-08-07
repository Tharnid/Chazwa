namespace Sigh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEmployee")]
    public class tblEmployee
    {
        [MetadataType(typeof (EmployeeMetaData))]
        public partial class Employee
        {
        }

        public class EmployeeMetaData
        {
            [Required]
            public string Name { get; set; }

            [Required]
            public string Gender { get; set; }

            [Required]
            public string City { get; set; }

            [Required]
            [Display(Name = "Department")]
            public int DepartmentId { get; set; }
        }
    }
}
