namespace EFModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string InvoiceCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string InvoiceClass { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal InvoiceTotal { get; set; }
    }
}
