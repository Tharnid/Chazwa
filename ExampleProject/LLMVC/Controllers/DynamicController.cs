using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LLMVC.Controllers
{
    public class DynamicController : Controller
    {
        // GET: Dynamic
        public ActionResult Index(string text = "default value" )
        {
            ViewBag.DisplayText = text;
            return View();
        }

        //public ActionResult Show(int prod, string loc)
        //{
        //    return View();
        //}
    }
}