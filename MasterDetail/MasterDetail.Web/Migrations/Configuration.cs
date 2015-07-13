namespace MasterDetail.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

<<<<<<< HEAD
    internal sealed class Configuration : DbMigrationsConfiguration<MasterDetail.Web.Models.ApplicationDbContext>
=======
    internal sealed class Configuration : DbMigrationsConfiguration<MasterDetail.Models.ApplicationDbContext>
>>>>>>> cd696de23f5f55793b4e876577c6152d62e07bf4
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

<<<<<<< HEAD
        protected override void Seed(MasterDetail.Web.Models.ApplicationDbContext context)
=======
        protected override void Seed(MasterDetail.Models.ApplicationDbContext context)
>>>>>>> cd696de23f5f55793b4e876577c6152d62e07bf4
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
