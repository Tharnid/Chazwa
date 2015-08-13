namespace Ang2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.vTerritorySalesDrilldown")]
    public partial class vTerritorySalesDrilldown
    {
        public long? ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TerritoryName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesPersonID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string EmployeeFirstName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string EmployeeLastName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Total { get; set; }
    }
}
