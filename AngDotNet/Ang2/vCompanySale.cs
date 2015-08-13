namespace Ang2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.vCompanySales")]
    public partial class vCompanySale
    {
        public long? ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ProductCategory { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProductSubCategory { get; set; }

        public int? OrderYear { get; set; }

        [StringLength(31)]
        public string OrderQtr { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sales { get; set; }
    }
}
