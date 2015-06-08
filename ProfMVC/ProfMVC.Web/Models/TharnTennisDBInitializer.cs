using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfMVC.Web.Models
{
    public class TharnTennisDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<TharnTennisDB>
    {
        protected override void Seed(TharnTennisDB context)
        {

            
            base.Seed(context);
        }
    }
}