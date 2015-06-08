using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PCEF.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                // defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                // changing to SalesController
                defaults: new { controller = "Sales", action = "Index", id = UrlParameter.Optional }
                );
        }
    }
}
