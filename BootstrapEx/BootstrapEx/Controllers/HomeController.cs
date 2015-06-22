using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapEx.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult SummaryBlock()
        {
            return View();
        }

        public ActionResult SummaryBlockEx()
        {
            return View();
        }

        public ActionResult ReadmeBox()
        {
            return View();
        }

        public ActionResult AdvReadmeBox()
        {
            return View();
        }

        public ActionResult DDL()
        {
            return View();
        }

        public ActionResult DDL2()
        {
            return View();
        }
    }
}