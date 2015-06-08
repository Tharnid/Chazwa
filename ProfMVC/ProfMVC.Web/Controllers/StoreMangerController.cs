using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProfMVC.Web.Models;

namespace ProfMVC.Web.Controllers
{
    public class StoreMangerController : Controller
    {
        private TharnTennisDB db = new TharnTennisDB();
        // eager loading - attempts to load all data with one query
        // lazy loading - only loads the primary object and leaves the rest properties unpopulated

        // GET: StoreManger
        public ActionResult Index()
        {
            return View(db.Racquets.ToList());
        }

        // GET: StoreManger/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Racquet racquet = db.Racquets.Find(id);
            if (racquet == null)
            {
                return HttpNotFound();
            }
            return View(racquet);
        }

        // GET: StoreManger/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreManger/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RacquetId,ManufacturerId,HeadSize,Length,StrungWeight,SwingWeight,Stiffness,PowerLevel,StrokeStyle,SwingSpeed,StringPattern,SmartSensorReady,Price")] Racquet racquet)
        {
            if (ModelState.IsValid)
            {
                db.Racquets.Add(racquet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(racquet);
        }

        // GET: StoreManger/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Racquet racquet = db.Racquets.Find(id);
            if (racquet == null)
            {
                return HttpNotFound();
            }
            return View(racquet);
        }

        // POST: StoreManger/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RacquetId,ManufacturerId,HeadSize,Length,StrungWeight,SwingWeight,Stiffness,PowerLevel,StrokeStyle,SwingSpeed,StringPattern,SmartSensorReady,Price")] Racquet racquet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(racquet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(racquet);
        }

        // GET: StoreManger/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Racquet racquet = db.Racquets.Find(id);
            if (racquet == null)
            {
                return HttpNotFound();
            }
            return View(racquet);
        }

        // POST: StoreManger/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Racquet racquet = db.Racquets.Find(id);
            db.Racquets.Remove(racquet);
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
