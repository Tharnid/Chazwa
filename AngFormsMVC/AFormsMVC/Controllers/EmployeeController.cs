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

            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(list, camelCaseFormatter),
                ContentType = "application/json"
            };
            //return jsonResult;
            return new HttpStatusCodeResult(404, "Our custom message here.....");
        }

        public ActionResult Create(EmployeeVM employee)
        {
            //if (ModelState.IsValid)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.Created, "New employee added");
            //}

            //return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);

            return new HttpStatusCodeResult(201, "New Employee added!!!");
        }
    }
}