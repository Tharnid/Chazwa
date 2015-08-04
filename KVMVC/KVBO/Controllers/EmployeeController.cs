using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace KVBO.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();

            List<Employee> emp = ebl.Employees.ToList();

            return View(emp);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}