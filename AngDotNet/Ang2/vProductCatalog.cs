namespace Ang2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Production.vProductCatalog")]
    public partial class vProductCatalog
    {
        public long? ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ProductModel { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string ProductCategory { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string ProductSubcategory { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(400)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(6)]
        public string CultureID { get; set; }

        [StringLength(15)]
        public string Color { get; set; }

        [StringLength(5)]
        public string Size { get; set; }

        public decimal? Weight { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal ListPrice { get; set; }
    }
}
