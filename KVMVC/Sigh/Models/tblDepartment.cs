namespace Sigh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDepartment")]
    public class tblDepartment
    {
        public tblDepartment()
        {
            tblEmployees = new HashSet<tblEmployee>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
