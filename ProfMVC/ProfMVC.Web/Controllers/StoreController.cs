﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfMVC.Web.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "Hello from Store.Index()";
        }

        //public string Browse()
        //{
        //    return "Hello from Store.Browse()";
        //}

        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        //public string Details()
        //{
        //    return "Hello from Store.Details()";
        //}

        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}