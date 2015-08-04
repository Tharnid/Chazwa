namespace BleepModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Conference")]
    public partial class Conference
    {
        [Key]
        [Column(Order = 0)]
        public int ConferenceId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ConferenceName { get; set; }

        public virtual ICollection<School> School { get; set; } 
    }
}
