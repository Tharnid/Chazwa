namespace PCEF.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PCEF.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<PCEF.DAL.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // ok to destroy data during migration process
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PCEF.DAL.SalesContext context)
        {
            context.SalesOrders.AddOrUpdate(
                so => so.CustomerName,
                new SalesOrder { CustomerName = "Adam", PONumber = "9876" },
                new SalesOrder { CustomerName = "Michael" },
                new SalesOrder { CustomerName = "David", PONumber = "Acme 9" }
                );
        }
    }
}
