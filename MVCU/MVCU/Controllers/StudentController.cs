using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCU.Models;
using MVCU.DAL;

namespace MVCU.Controllers
{
    public class StudentController : Controller
    {
        
        // set up context
        private SchoolContext db = new SchoolContext();

        // GET: Student
        public ViewResult Index()
        {
            return View(db.Students.ToList());
        }
    }
}