using SolutionName.Model;

namespace SolutionName.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SolutionName.DataLayer.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SolutionName.DataLayer.SalesContext context)
        {
            context.SalesOrders.AddOrUpdate(
                so => so.CustomerName,
                new SalesOrder { CustomerName = "Adam", PONumber = "9876"},
                new SalesOrder { CustomerName = "Michael"},
                new SalesOrder { CustomerName = "David", PONumber = "Acme 9"}
                );
        }
    }
}