﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Basics.Controllers
{
    public class CountryController : Controller
    {
        
        // List
        public ActionResult Index()  // views inherit from action result
        {
            //return new List<string>()  // returns name of the type
            //{
            //    "India",
            //    "US",
            //    "UK",
            //    "Canada"
            //};

            // Convert to ViewBag
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