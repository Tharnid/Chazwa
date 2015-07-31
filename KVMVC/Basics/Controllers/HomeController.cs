using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Basics.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index(string id)
        {
            // return View();
            // return "Hello from MVC Application!!!";
            // return "Id = " + id; // pass that by going to Home/Index/XXXX XXXX being whatever number
            // you can see the trace information by typing trace.axd
            return "Id = " + id + " " + "Name = " + Request.QueryString["name"];  // passed through URL
        }

        public string GetDetails()
        {
            return "GetDetails Invoked!!!";
        }
    }
}