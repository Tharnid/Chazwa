using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Security.Claims;
using System.Threading.Tasks;
using Experimentation.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Experimentation.Shared.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Models.Company> Company { get; set; }
        public System.Data.Entity.DbSet<Models.Integrations> Integrations { get; set; }
        public System.Data.Entity.DbSet<Models.Person> Person { get; set; }
        public System.Data.Entity.DbSet<Models.SharedCountry> SharedCountry { get; set; }
        public System.Data.Entity.DbSet<Models.SharedCurrency> SharedCurrency { get; set; }
        public System.Data.Entity.DbSet<Models.SharedState> SharedState { get; set; }
        public System.Data.Entity.DbSet<Models.Tenant> Tenant { get; set; }
        public System.Data.Entity.DbSet<Models.Customer> Customer { get; set; }
        public System.Data.Entity.DbSet<Models.CustomerClass> CustomerClass { get; set; }
        public System.Data.Entity.DbSet<Models.ShipTo> ShipTo { get; set; }
        public System.Data.Entity.DbSet<Models.IncomingXmlArchive> IncomingXmlArchive { get; set; }
        public System.Data.Entity.DbSet<Models.Inv> Inv { get; set; }
        public System.Data.Entity.DbSet<Models.InvLine> InvLine { get; set; }
        public System.Data.Entity.DbSet<Models.Item> Item { get; set; }
        public System.Data.Entity.DbSet<Models.ItemClass> ItemClass { get; set; }
        public System.Data.Entity.DbSet<Models.Ord> Ord { get; set; }
        public System.Data.Entity.DbSet<Models.OrdLine> OrdLine { get; set; }
        public System.Data.Entity.DbSet<Models.IncomingXmlQueue> IncomingXmlQueue { get; set; }


    }
}
