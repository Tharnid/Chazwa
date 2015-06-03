using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParentChildData.Model;

namespace ParentChildData.DataLayer
{
    public class SalesContext : DbContext 
    {
        public SalesContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<SalesOrder> SalesOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new SalesOrderConfiguration());
        }
    }
}
