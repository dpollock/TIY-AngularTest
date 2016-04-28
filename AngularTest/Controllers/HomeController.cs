using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularTest.Models;

namespace AngularTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllCars()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            
            return Json(db.Cars.ToList(),JsonRequestBehavior.AllowGet);
        }

        public ActionResult SaveCar(Car c)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            db.Cars.Add(c);
            db.SaveChanges();

            return Json(c);
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
    }
}