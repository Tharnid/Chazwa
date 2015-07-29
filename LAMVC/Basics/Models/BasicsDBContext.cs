using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Basics.Models
{
    public class BasicsDBContext : DbContext
    {
        public BasicsDBContext()
            : base("BasicsConnection")
        {
            
        }

        public static BasicsDBContext Create()
        {
            return new BasicsDBContext();
        }

        public System.Data.Entity.DbSet<Models.Customer> Customer { get; set; }
        public System.Data.Entity.DbSet<Models.Order> Order { get; set; } 
    }
}