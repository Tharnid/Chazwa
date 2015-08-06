using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sigh.Models;

namespace Sigh.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            CompanyDB cdb = new CompanyDB();
            // All - Employees - List<tblEmployee> employees = cdb.tblEmployees.ToList();
            // Sort by DepartmentId
            List<tblEmployee> employees = cdb.tblEmployees.Where(emp => emp.DepartmentId == departmentId).ToList();

            return View(employees);
        }

        // GET: Employee
        public ActionResult Details(int id)
        {
            //tblEmployee emp = new tblEmployee();
            //{
            //    emp.EmployeeId = 101;
            //    emp.Name = "John";
            //    emp.Gender = "Male";
            //    emp.City = "London";
            //};

            CompanyDB cdb = new CompanyDB();

            tblEmployee emp = cdb.tblEmployees.Single(x => x.EmployeeId == id);

            return View(emp);
        }
    }
}