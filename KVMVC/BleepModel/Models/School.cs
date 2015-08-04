namespace BleepModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("School")]
    public partial class School
    {
        public int SchoolId { get; set; }

        public int ConferenceId { get; set; }

        [Required]
        [StringLength(30)]
        public string SchoolName { get; set; }

        [Required]
        [StringLength(40)]
        public string SchoolMascot { get; set; }
    }
}
