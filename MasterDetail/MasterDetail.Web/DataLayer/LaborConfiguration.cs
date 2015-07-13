using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using MasterDetail.Web.Models;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDetail.Web.DataLayer
=======
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using MasterDetail.Models;

namespace MasterDetail.DataLayer
>>>>>>> cd696de23f5f55793b4e876577c6152d62e07bf4
{
    public class LaborConfiguration : EntityTypeConfiguration<Labor>
    {
        public LaborConfiguration()
        {
            Property(l => l.ServiceItemCode)
                .HasMaxLength(15)
                .IsRequired()
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("AK_Labor", 2) { IsUnique = true }));

            Property(l => l.WorkOrderId)
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("AK_Labor", 1) { IsUnique = true }));

            Property(l => l.ServiceItemName)
                .HasMaxLength(80)
                .IsRequired();

            Property(l => l.LaborHours).HasPrecision(18, 2);

            Property(l => l.Rate).HasPrecision(18, 2);

            Property(l => l.ExtendedPrice)
                .HasPrecision(18, 2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(l => l.Notes).HasMaxLength(140).IsOptional();
        }
    }
}