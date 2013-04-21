using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheWall.Model;
using TheWall.Model.Extensions;

namespace TheWall.Web.Controllers
{
    public class StatisticsController : Controller
    {
        private TheWallEntities db = new TheWallEntities();

        private string chartFilter;
        private int courseId;
        public StatisticsController()
        {
            chartFilter = "Females";
        }
        //
        // GET: /Statistics/

        public ActionResult Index(int CourseId = 1)
        {
            this.courseId = CourseId;
            Highcharts chart = this.getGeneralChart();

            if (chartFilter == "Females")
            {
                chart = getFemalesChart();
            }

            else if (chartFilter == "Males")
            {
                chart = getMalesChart();
            }
   

            return View(chart);
        }

        private Highcharts getGeneralChart()
        {
            Highcharts chart =
                new DotNet.Highcharts.Highcharts("chart")
            .SetTitle(new Title
            {
                Text = "General student reaction to the educational experience"
            })
    .SetXAxis(new XAxis
    {
        Categories = new[] { "Sad", "Happy", "Angry" }
    })
    .SetSeries(new Series
    {
        Data = new Data(new object[] { 
            db.Feedbacks.Where(f => f.Mood.Description == "Sad" && f.Course.Id == this.courseId).Count(),
            db.Feedbacks.Where(f => f.Mood.Description == "Happy" && f.Course.Id == this.courseId).Count(),
            db.Feedbacks.Where(f => f.Mood.Description == "Angry" && f.Course.Id == this.courseId).Count()
        })


    });
            return chart;
        }

        private Highcharts getFemalesChart()
        {
            Highcharts chart =
                new DotNet.Highcharts.Highcharts("chart")
            .SetTitle(new Title
            {
                Text = "Female students reaction to the educational experience"
            })
    .SetXAxis(new XAxis
    {
        Categories = new[] { "Sad", "Happy", "Angry" }
    })
    .SetSeries(new Series
    {
        Data = new Data(new object[] { 
            db.Feedbacks.Where(f => f.Mood.Description == "Sad" && f.Course.Id == this.courseId && f.Student.Gender.Name == "Female").Count(),
            db.Feedbacks.Where(f => f.Mood.Description == "Happy" && f.Course.Id == this.courseId && f.Student.Gender.Name == "Female").Count(),
            db.Feedbacks.Where(f => f.Mood.Description == "Angry" && f.Course.Id == this.courseId && f.Student.Gender.Name == "Female").Count()

        })


    });
            return chart;
        }

        private Highcharts getMalesChart()
        {
            Highcharts chart =
                new DotNet.Highcharts.Highcharts("chart")
            .SetTitle(new Title
            {
                Text = "Female students reaction to the educational experience"
            })
    .SetXAxis(new XAxis
    {
        Categories = new[] { "Sad", "Happy", "Angry" }
    })
    .SetSeries(new Series
    {
        Data = new Data(new object[] { 
            db.Feedbacks.Where(f => f.Mood.Description == "Sad" && f.Course.Id == this.courseId && f.Student.Gender.Name == "Male").Count(),
            db.Feedbacks.Where(f => f.Mood.Description == "Happy" && f.Course.Id == this.courseId && f.Student.Gender.Name == "Male").Count(),
            db.Feedbacks.Where(f => f.Mood.Description == "Angry" && f.Course.Id == this.courseId && f.Student.Gender.Name == "Male").Count()
        })


    });
            return chart;
        }

        //
        // GET: /Statistics/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Statistics/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Statistics/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Statistics/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Statistics/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Statistics/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Statistics/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
