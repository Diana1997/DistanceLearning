using DistanceLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DistanceLearning.Controllers
{
    public class HomeController : Controller
    {
        private DistanceLearningEntities db = new DistanceLearningEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LearnService()
        {
            return View();
        }
        public ActionResult LearnStatement()
        {
            ViewBag.FacultyID = new SelectList(db.Faculties, "FacultyID", "Name");
            ViewBag.TribuneID = new SelectList(db.Tribunes, "TribuneID", "Name");
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Name");
            return View();
        }
    }
}