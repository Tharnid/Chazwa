namespace Ang2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Production.vWorkOrderRouting")]
    public partial class vWorkOrderRouting
    {
        public long? ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkOrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OperationSequence { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LocationID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime ScheduledStartDate { get; set; }

        public DateTime? ActualStartDate { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime ScheduledEndDate { get; set; }

        public DateTime? ActualEndDate { get; set; }

        public decimal? ActualResourceHrs { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal PlannedCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualCost { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderQty { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ScrappedQty { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime DueDate { get; set; }

        public short? ScrapReasonID { get; set; }

        [StringLength(50)]
        public string ScrapReason { get; set; }
    }
}
