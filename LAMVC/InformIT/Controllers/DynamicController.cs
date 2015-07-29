using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InformIT.Controllers
{
    public class DynamicController : Controller
    {
        // GET: Dynamic
        public ActionResult Index(string text)
        {
            ViewBag.DisplayText = text;

            return View();
        }

        public ActionResult Show(string text = "What the fuck ever!!!")
        {
            ViewBag.DisplayText = text;

            return View();
        }

        public ActionResult QueryString(string text)
        {
            return View();
        }

        public ActionResult Goto(string gotoUrl)
        {
            return Redirect(gotoUrl);
        }
    }
}