using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using MasterDetail.Web.Models;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
=======
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Web;
using MasterDetail.Models;
>>>>>>> cd696de23f5f55793b4e876577c6152d62e07bf4

namespace MasterDetail.Web.DataLayer
{
    public class WorkOrderConfiguration : EntityTypeConfiguration<WorkOrder>
    {
        public WorkOrderConfiguration()
        {
            Property(wo => wo.OrderDateTime).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(wo => wo.Description).HasMaxLength(256).IsOptional();
            Property(wo => wo.Total).HasPrecision(18, 2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(wo => wo.CertificationRequirements).HasMaxLength(120).IsOptional();
        }
    }
}