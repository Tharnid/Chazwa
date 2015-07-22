using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LLMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Using ViewBag
            ViewBag.Message = "something to show on this page please!!!";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}