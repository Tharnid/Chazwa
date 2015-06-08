using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProfMVC.Web.Models
{
    public class TharnTennisDB : DbContext
    {
        public DbSet<Racquet> Racquets { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}