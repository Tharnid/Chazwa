using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExampleProject.Models;

namespace ExampleProject.Controllers
{
    public class ShipToController : Controller
    {
        private ExampleDBContext db = new ExampleDBContext();

        // GET: ShipTo
        public ActionResult Index()
        {
            return View(db.ShipTo.ToList());
        }

        // GET: ShipTo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShipTo shipTo = db.ShipTo.Find(id);
            if (shipTo == null)
            {
                return HttpNotFound();
            }
            return View(shipTo);
        }

        // GET: ShipTo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShipTo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyId,CustomerId,ShipToId,Name,Address1,Address2,Address3,Address4,City,County,StateCode,CountryCode,PostalCode,RemoteId,VariationId")] ShipTo shipTo)
        {
            if (ModelState.IsValid)
            {
                db.ShipTo.Add(shipTo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shipTo);
        }

        // GET: ShipTo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShipTo shipTo = db.ShipTo.Find(id);
            if (shipTo == null)
            {
                return HttpNotFound();
            }
            return View(shipTo);
        }

        // POST: ShipTo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyId,CustomerId,ShipToId,Name,Address1,Address2,Address3,Address4,City,County,StateCode,CountryCode,PostalCode,RemoteId,VariationId")] ShipTo shipTo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shipTo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shipTo);
        }

        // GET: ShipTo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShipTo shipTo = db.ShipTo.Find(id);
            if (shipTo == null)
            {
                return HttpNotFound();
            }
            return View(shipTo);
        }

        // POST: ShipTo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShipTo shipTo = db.ShipTo.Find(id);
            db.ShipTo.Remove(shipTo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
