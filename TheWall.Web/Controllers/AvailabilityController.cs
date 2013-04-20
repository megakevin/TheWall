using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheWall.Model;

namespace TheWall.Web.Controllers
{
    public class AvailabilityController : Controller
    {
        private TheWallEntities db = new TheWallEntities();

        //
        // GET: /Availability/

        public ActionResult Index()
        {
            return View(db.Availabilities.ToList());
        }

        //
        // GET: /Availability/Details/5

        public ActionResult Details(int id = 0)
        {
            Availability availability = db.Availabilities.Find(id);
            if (availability == null)
            {
                return HttpNotFound();
            }
            return View(availability);
        }

        //
        // GET: /Availability/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Availability/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Availability availability)
        {
            if (ModelState.IsValid)
            {
                db.Availabilities.Add(availability);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(availability);
        }

        //
        // GET: /Availability/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Availability availability = db.Availabilities.Find(id);
            if (availability == null)
            {
                return HttpNotFound();
            }
            return View(availability);
        }

        //
        // POST: /Availability/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Availability availability)
        {
            if (ModelState.IsValid)
            {
                db.Entry(availability).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(availability);
        }

        //
        // GET: /Availability/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Availability availability = db.Availabilities.Find(id);
            if (availability == null)
            {
                return HttpNotFound();
            }
            return View(availability);
        }

        //
        // POST: /Availability/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Availability availability = db.Availabilities.Find(id);
            db.Availabilities.Remove(availability);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}