using DistanceLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DistanceLearning.Controllers
{
    public class LearnController : Controller
    {
        private DistanceLearningEntities db = new DistanceLearningEntities();

        // GET: Learn
        public ActionResult Index()
        {
           // var faculties = db.Faculties.ToList();
            return View(db.Faculties);
        }
        public ActionResult GetTribune(int? id)
        {
            var tribunes = db.Tribunes.Where(x => x.FacultyID == id);  
            return View();
        }
    }
}