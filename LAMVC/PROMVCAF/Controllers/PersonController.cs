using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROMVCAF.Models;

namespace PROMVCAF.Controllers
{


    public class PersonController : Controller
    {

        private Person[] personData =
    {
             new Person {PersonId = 1, FirstName = "Adam", LastName = "Freeman",
                Role = Role.Admin},
            new Person {PersonId = 2, FirstName = "Jacqui", LastName = "Griffyth",
                Role = Role.User},
            new Person {PersonId = 3, FirstName = "John", LastName = "Smith",
                Role = Role.User},
            new Person {PersonId = 4, FirstName = "Anne", LastName = "Jones",
                Role = Role.Guest}       
    };

        // GET: Person
        public ActionResult Index(int id = 1) // using a default parameter otherwise it blows up
        {
            Person dataItem = personData.Where(p => p.PersonId == id).First();
            return View(dataItem);
        }
    }
}