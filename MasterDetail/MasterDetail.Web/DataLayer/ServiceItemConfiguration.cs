﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using MasterDetail.Models;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDetail.Web.DataLayer
{
    public class ServiceItemConfiguration : EntityTypeConfiguration<ServiceItem>
    {
        public ServiceItemConfiguration()
        {
            Property(si => si.ServiceItemCode)
                .HasMaxLength(15)
                .IsRequired()
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("AK_ServiceItem_ServiceItemCode") { IsUnique = true }));

            Property(si => si.ServiceItemName)
                .HasMaxLength(80)
                .IsRequired()
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("AK_ServiceItem_ServiceItemName") { IsUnique = true }));

            Property(si => si.Rate).HasPrecision(18, 2);
        }
    }
}