using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DropdownStudy21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var departments = new SelectList(db.Departments.ToList(), "Id", "Name");

           // ViewData["Departments"] = departments;

            List<SelectListItem> myskills = new List<SelectListItem>()
            {
                   new SelectListItem{Text="Asp.Net",Value="1"},
                   new SelectListItem{Text="Asp.Net MVC",Value="2"},
                   new SelectListItem{Text="LINQ",Value="3"},
                   new SelectListItem{Text="Angular",Value="4"},
                   new SelectListItem{Text="JQuery",Value="5"},
                   new SelectListItem{Text="AJAX",Value="6"},
            };
            ViewData["data"] = myskills;

            ViewBag.Skills = myskills;


            TempData["MySkills"] = myskills;

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
    }
}