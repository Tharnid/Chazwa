namespace BleepModel.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ConfEntities : DbContext
    {
        public ConfEntities()
            : base("name=ConfEntities")
        {
        }

        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Conference> Conferences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
