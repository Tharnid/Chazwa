﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCU.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace MVCU.DAL
{
    public class SchoolContext : DbContext
    {
    
        public SchoolContext() : base("SchoolContext")
        {
        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
