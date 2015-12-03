using AFormsMVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace AFormsMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult GetEmployees()
        {
            List<EmployeeVM> list = new List<EmployeeVM>()
            {
                new EmployeeVM() {
                    FullName = "Milton Waddams"
                },
                new EmployeeVM() {
                    FullName = "Andy Bernard"
                }
            };

            //var camelCaseFormatter = new JsonSerializerSettings();
            //camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //var jsonResult = new ContentResult
            //{
            //    Content = JsonConvert.SerializeObject(list, camelCaseFormatter),
            //    ContentType = "application/json"
            //};
            //return jsonResult;
            // return new HttpStatusCodeResult(404, "Our custom error message...");

            return GetJsonContentResult(list);
        }

        public ActionResult Create([Bind(Prefix="NewEmployee")] EmployeeVM employee) // [Bind(Exclude="Notes")] [Bind(Include="Notes")]...without prefix employee not populated!!!
        // Include White list
        // Exclude Black list
        // Prefix 
        {
            if (ModelState.IsValid)
            {
                // return assigned id
                var id = new { id = 12345 };
                //return new HttpStatusCodeResult(HttpStatusCode.Created, "New employee added");
                return GetJsonContentResult(id);
            }

            List<string> errors = new List<string>();
            errors.Add("Insert failed.");
            if (!ModelState.IsValidField("Notes"))
                errors.Add("Notes must be at least 5 characters long.");

            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError,
                String.Join("  ", errors));

        }

        public ActionResult Update(EmployeeVM employee)
        {
            if (ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.OK, "Update success");
            }

            List<string> errors = new List<string>();
            errors.Add("Update failed.");
            if (!ModelState.IsValidField("Notes"))
                errors.Add("Notes must be at least 5 characters long.");

            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError,
                String.Join("  ", errors));

        }

        public ContentResult GetJsonContentResult(object data)
        {
            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(data, camelCaseFormatter),
                ContentType = "application/json"
            };

            return jsonResult;
        }
    }
}