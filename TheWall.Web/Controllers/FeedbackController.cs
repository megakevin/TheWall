using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheWall.Model;
using WebMatrix.WebData;

namespace TheWall.Web.Controllers
{
    public class FeedbackController : Controller
    {
        private TheWallEntities db = new TheWallEntities();

        //
        // GET: /Feedback/

        public ActionResult Index(string id)
        {
            int CourseId = Convert.ToInt32(id);

            var feedbacks = db.Feedbacks.Where(f => f.CourseId == CourseId).Include(f => f.Course).Include(f => f.Mood).Include(f => f.Student);
            return PartialView(feedbacks.ToList());
        }

        //
        // GET: /Feedback/Details/5

        public ActionResult Details(int id = 0)
        {
            Feedback feedback = db.Feedbacks.Find(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }

        //
        // GET: /Feedback/Create

        public ActionResult Create(string id)
        {
            int CourseId = Convert.ToInt32(id);
            int StudentId = 0;

            //try
            //{
                StudentId = db.Students.Where(s => s.UserId == WebSecurity.CurrentUserId).First().Id;
            //}
            //catch (Exception ex)
            //{
            //    return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Index", "Course") });
            //}                       

            ViewBag.MoodId = new SelectList(db.Moods, "Id", "Description");
            return PartialView(new Feedback() { CourseId = CourseId, StudentId = StudentId });
        }

        //
        // POST: /Feedback/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                db.Feedbacks.Add(feedback);
                db.SaveChanges();

                ViewBag.MoodId = new SelectList(db.Moods, "Id", "Description", feedback.MoodId);

                return PartialView(new Feedback() { CourseId = feedback.CourseId, StudentId = feedback.StudentId });// RedirectToAction("Index", "Course");
            }

            //ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", feedback.CourseId);
            ViewBag.MoodId = new SelectList(db.Moods, "Id", "Description", feedback.MoodId);
            //ViewBag.StudentId = new SelectList(db.Students, "Id", "FirstName", feedback.StudentId);

            return PartialView(new Feedback() { CourseId = feedback.CourseId, StudentId = feedback.StudentId }); //return RedirectToAction("Index", "Course");
        }

        //
        // GET: /Feedback/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Feedback feedback = db.Feedbacks.Find(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", feedback.CourseId);
            ViewBag.MoodId = new SelectList(db.Moods, "Id", "Description", feedback.MoodId);
            ViewBag.StudentId = new SelectList(db.Students, "Id", "FirstName", feedback.StudentId);
            return View(feedback);
        }

        //
        // POST: /Feedback/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feedback).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", feedback.CourseId);
            ViewBag.MoodId = new SelectList(db.Moods, "Id", "Description", feedback.MoodId);
            ViewBag.StudentId = new SelectList(db.Students, "Id", "FirstName", feedback.StudentId);
            return View(feedback);
        }

        //
        // GET: /Feedback/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Feedback feedback = db.Feedbacks.Find(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }

        //
        // POST: /Feedback/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Feedback feedback = db.Feedbacks.Find(id);
            db.Feedbacks.Remove(feedback);
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