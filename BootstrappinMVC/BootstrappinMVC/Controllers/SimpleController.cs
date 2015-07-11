using BootstrappinMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrappinMVC.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult Index()
        {
            var person = new Person
            {
                FirstName = "Jason ",
                LastName = "Terrell",
                BirthDate = new DateTime(1972, 8, 24),
                LikesMusic = true,
                Skills = new List<string>() { "Dreamweaver", "Illustrator", "Photoshop", "CSS", "Html5" }
            };

            return View(person);
        }

        public ActionResult I2()
        {
            var person = new Person
            {
                FirstName = "Jason ",
                LastName = "Terrell",
                BirthDate = new DateTime(1972, 8, 24),
                LikesMusic = true,
                Skills = new List<string>() { "Dreamweaver", "Illustrator", "Photoshop", "CSS", "Html5" }
            };

            return View(person);
        }
    }
}