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
    public class ReasonController : Controller
    {
        private TheWallEntities db = new TheWallEntities();

        //
        // GET: /Reason/

        public ActionResult Index()
        {
            var reasons = db.Reasons.Include(r => r.Mood);
            return View(reasons.ToList());
        }

        //
        // GET: /Reason/Details/5

        public ActionResult Details(int id = 0)
        {
            Reason reason = db.Reasons.Find(id);
            if (reason == null)
            {
                return HttpNotFound();
            }
            return View(reason);
        }

        //
        // GET: /Reason/Create

        public ActionResult Create()
        {
            ViewBag.MoodId = new SelectList(db.Moods, "MoodId", "Description");
            return View();
        }

        //
        // POST: /Reason/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reason reason)
        {
            if (ModelState.IsValid)
            {
                db.Reasons.Add(reason);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MoodId = new SelectList(db.Moods, "MoodId", "Description", reason.MoodId);
            return View(reason);
        }

        //
        // GET: /Reason/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Reason reason = db.Reasons.Find(id);
            if (reason == null)
            {
                return HttpNotFound();
            }
            ViewBag.MoodId = new SelectList(db.Moods, "MoodId", "Description", reason.MoodId);
            return View(reason);
        }

        //
        // POST: /Reason/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Reason reason)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reason).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MoodId = new SelectList(db.Moods, "MoodId", "Description", reason.MoodId);
            return View(reason);
        }

        //
        // GET: /Reason/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Reason reason = db.Reasons.Find(id);
            if (reason == null)
            {
                return HttpNotFound();
            }
            return View(reason);
        }

        //
        // POST: /Reason/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reason reason = db.Reasons.Find(id);
            db.Reasons.Remove(reason);
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