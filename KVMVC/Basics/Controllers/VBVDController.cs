using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Basics.Controllers
{
    public class VBVDController : Controller
    {
        // GET: VBVD
        public ActionResult Index()
        {
            // ViewData || ViewData["WhateverTheKey"]
            // ViewBag || ViewBag.YourProperty = "Whatever";

            ViewBag.Countries = new List<string>()
            {
                    "India",
                    "US",
                    "UK",
                    "Canada"
            };

            ViewData["Capitals"] = new List<string>()
            {
                "New Dehli",
                "Washington DC",
                "London",
                "Ottawa"
            };

            return View();
        }
    }
}