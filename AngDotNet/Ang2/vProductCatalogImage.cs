namespace Ang2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Production.vProductCatalogImages")]
    public partial class vProductCatalogImage
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductPhotoID { get; set; }

        public byte[] ThumbNailPhoto { get; set; }

        [StringLength(50)]
        public string ThumbnailPhotoFileName { get; set; }

        public byte[] LargePhoto { get; set; }

        [StringLength(50)]
        public string LargePhotoFileName { get; set; }
    }
}
