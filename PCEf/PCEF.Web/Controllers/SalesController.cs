using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PCEF.DAL;
using PCEF.Model;
using PCEF.Web.ViewModels;

namespace PCEF.Web.Controllers
{
    public class SalesController : Controller
    {
        private SalesContext _salesContext = new SalesContext();

        public SalesController()
        {
            _salesContext = new SalesContext();
        }

        public ActionResult Index()
        {
            return View(_salesContext.SalesOrders.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrder salesOrder = _salesContext.SalesOrders.Find(id);
            if (salesOrder == null)
            {
                return HttpNotFound();
            }

            // example of how to use the ViewModel
            SalesOrderViewModel salesOrderViewModel = new SalesOrderViewModel();
            
            // set the matching properties
            salesOrderViewModel.SalesOrderId = salesOrder.SalesOrderId;
            salesOrderViewModel.CustomerName = salesOrder.CustomerName;
            salesOrderViewModel.PONumber = salesOrder.PONumber;
            salesOrderViewModel.MessageToClient = "I originated from the ViewModel, rather than the model!!!";


            return View(salesOrderViewModel);
        }

        public ActionResult Create()
        {
            SalesOrderViewModel salesOrderViewModel = new SalesOrderViewModel();


            return View(salesOrderViewModel);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrder salesOrder = _salesContext.SalesOrders.Find(id);
            if (salesOrder == null)
            {
                return HttpNotFound();
            }
            return View(salesOrder);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrder salesOrder = _salesContext.SalesOrders.Find(id);
            if (salesOrder == null)
            {
                return HttpNotFound();
            }

            // some of the same stuff from the create
            SalesOrderViewModel salesOrderViewModel = new SalesOrderViewModel();
            salesOrderViewModel.SalesOrderId = salesOrder.SalesOrderId;
            salesOrderViewModel.CustomerName = salesOrder.CustomerName;
            salesOrderViewModel.PONumber = salesOrder.PONumber;
            salesOrderViewModel.MessageToClient = string.Format("The original value of Customer Name is {0}.", salesOrderViewModel.CustomerName);
            // salesOrderViewModel.ObjectState = ObjectState.Unchanged;

            return View(salesOrderViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _salesContext.Dispose();
            }
            base.Dispose(disposing);
        }

        // Save JsonResult
        public JsonResult Save(SalesOrderViewModel salesOrderViewModel)
        {
            SalesOrder salesOrder = new SalesOrder();

            salesOrder.CustomerName = salesOrderViewModel.CustomerName;
            salesOrder.PONumber = salesOrderViewModel.PONumber;
            
            // add it to the context
            _salesContext.SalesOrders.Add(salesOrder);

            // Save changes to db
            _salesContext.SaveChanges();

            // Send message to the client
            salesOrderViewModel.MessageToClient = string.Format("{0}’s sales order has been added to the database.", salesOrder.CustomerName);

            // return the JSON
            return Json(new { salesOrderViewModel });
        }
    }
}
