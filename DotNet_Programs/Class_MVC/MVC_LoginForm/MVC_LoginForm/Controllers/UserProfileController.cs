using MVC_LoginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_LoginForm.Controllers
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
            if(ModelState.IsValid)
            {
                db = new myDB_SQLEntities();
                db.UserProfiles.Add(userProfile);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(userProfile);
        }

        public ActionResult Edit(int?Id)
        {
            db = new myDB_SQLEntities();
            var userProfile = db.UserProfiles.Find(Id);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserProfile userProfile)
        {
            db = new myDB_SQLEntities();
            var data = db.UserProfiles.Find(userProfile.UserId);
            if(data!=null)
            {
                data.Username = userProfile.Username;
                data.Password = userProfile.Password;
                data.IsActive = userProfile.IsActive;
            }
            db.SaveChanges();
            return View(data);
        }

    }
}