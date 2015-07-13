using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
<<<<<<< HEAD
using System.Web;
using MasterDetail.Web.Models;
=======
using System.Runtime.Remoting.Channels;
using System.Web;
using MasterDetail.Models;
>>>>>>> cd696de23f5f55793b4e876577c6152d62e07bf4

namespace MasterDetail.Web.DataLayer
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(c => c.CategoryName)
                .HasMaxLength(20)
                .IsRequired()
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("AK_Category_CategoryName") { IsUnique = true }));
        }
    }
}