namespace Sigh.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CompanyDB : DbContext
    {
        public CompanyDB()
            : base("name=CompanyDB")
        {
        }

        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblDepartment>()
                .HasMany(e => e.tblEmployees)
                .WithOptional(e => e.tblDepartment)
                .HasForeignKey(e => e.DepartmentId);
        }
    }
}
