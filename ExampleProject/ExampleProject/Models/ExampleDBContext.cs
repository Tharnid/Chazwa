using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleProject.Models
{
    public class ExampleDBContext : DbContext
    {
        public ExampleDBContext()
            : base("ExampleConnection")
        {
            
        }

        //public static ExampleDBContext Create()
        //{
        //    return new ExampleDBContext();
        //}

        public System.Data.Entity.DbSet<ExampleProject.Models.Customer> Customer { get; set; }
        public System.Data.Entity.DbSet<ExampleProject.Models.ShipTo> ShipTo { get; set; }
        public System.Data.Entity.DbSet<ExampleProject.Models.Company> Company { get; set; }
    }
}