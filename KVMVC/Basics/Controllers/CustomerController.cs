using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Basics.Models;

namespace Basics.Controllers
{
    public class CustomerController : Controller
    {
        // private readonly SalesEntities _salesEntitiesse;
        // GET: Customer
        public ActionResult CustomerDetails()
        {
            Customer customer = new Customer();
            {
                customer.CustomerId = 26;
                customer.FirstName = "Kyp";
                customer.LastName = "Durron";
                customer.PhoneNumber = "3334445555";
            };

            return View();
        }

        public ActionResult Employees()
        {
            Employee employee = new Employee();
            {
                employee.EmployeeId = 1;
                employee.FirstName = "Luke";
                employee.LastName = "Skywalker";
                employee.Gender = "Male";
                employee.PhoneNumber = "2225557777";
            };

            return View();
        }
    }
}