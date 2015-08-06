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
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? DepartmentId { get; set; }

        public virtual tblDepartment tblDepartment { get; set; }
    }
}
