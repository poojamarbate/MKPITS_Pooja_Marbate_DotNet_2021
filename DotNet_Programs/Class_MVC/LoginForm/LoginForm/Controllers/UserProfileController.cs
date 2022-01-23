using LoginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginForm.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: UserProfile
        myDB_SQLEntities db;

        public ActionResult Index()
        {
            db = new myDB_SQLEntities();
            return View(db.UserProfiles.ToList());
        }
      
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                db = new myDB_SQLEntities();
                db.UserProfiles.Add(userProfile);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(userProfile);
        }


    }
}