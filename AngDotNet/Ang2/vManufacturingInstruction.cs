namespace Ang2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Production.vManufacturingInstructions")]
    public partial class vManufacturingInstruction
    {
        public long? ID { get; set; }

        [Key]
        [Column(Order = 0)]
        public int ProductModelID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProductName { get; set; }

        public string Instructions { get; set; }

        public int? LocationID { get; set; }

        public decimal? SetupHours { get; set; }

        public decimal? MachineHours { get; set; }

        public decimal? LaborHours { get; set; }

        public int? LotSize { get; set; }

        [StringLength(1024)]
        public string Step { get; set; }
    }
}
