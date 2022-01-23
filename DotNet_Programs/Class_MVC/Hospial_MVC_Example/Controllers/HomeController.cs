using Hospial_MVC_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospial_MVC_Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.StudentNames = new List<Student>()
            {
                    new Student { firstname="Rani",lastname="sharma"},
                    new Student { firstname = "usha", lastname = "verma" },
                    new Student { firstname = "Rajvi", lastname = "sharma" },
                    new Student { firstname = "Rani", lastname = "sharma" },
                   new Student { firstname = "Rani", lastname = "sharma" },
            };
            ViewBag.Brandnames = new List<string>() { "nokia", "sony", "redme", "samsung" };
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
        public ActionResult MyView()
        {
            return View();
        }
    }
}