using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NavbarDataDriven.Controllers
{
    public class DDMController : Controller
    {
        // GET: DDM
        public ActionResult DDM1()
        {
            MenuItemManager1 mgr = new MenuItemManager1();

            mgr.Load();

            return View(mgr);
        }

        public ActionResult DDM2()
        {
            return View();
        }

        public ActionResult DDM3()
        {
            return View();
        }

        public ActionResult DDM4()
        {
            return View();
        }
    }
}