using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PCEF.Model;

namespace PCEF.DAL
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base("PCEF")
        {

        }

        public DbSet<SalesOrder> SalesOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new SalesOrderConfiguration());
        }

    }


}
