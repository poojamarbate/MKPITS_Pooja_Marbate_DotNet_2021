using MVC_Web_FormStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Web_FormStudy.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        myDB_SQLEntities db;
        public ActionResult Index()
        {
            db = new myDB_SQLEntities();
            return View(db.HiredPersons.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        //public ActionResult Create(FormCollection formCollection)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        HiredPerson person = new HiredPerson();
        //        person.fullname = formCollection["Fullname"];
        //        person.Gender = formCollection["Gender"];

        //    }
        //    return View();
        //}

        public ActionResult Create( HiredPerson person)
        {
            if (ModelState.IsValid)
            {
                db = new myDB_SQLEntities();
                db.HiredPersons.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);

        }

        public ActionResult Edit(int?Id)
        {
            db = new myDB_SQLEntities();
            var person = db.HiredPersons.Find(Id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HiredPerson person)
        {
            db = new myDB_SQLEntities();
            var data = db.HiredPersons.Find(person.ID);
            if (data != null)
            {
                data.fullname = person.fullname;
                data.Gender = person.Gender;
                data.Salary = person.Salary;
                data.Age = person.Age;
                data.Doj = person.Doj;
                data.EmailAddress = person.EmailAddress;

            }
            db.SaveChanges();
            return View(data);
        }

        public ActionResult Delete(int?Id)
        {
            db = new myDB_SQLEntities();
            HiredPerson person = db.HiredPersons.Find(Id);
            return View(person);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int ID)
        {
            db = new myDB_SQLEntities();
            HiredPerson person = db.HiredPersons.Find(ID);
          
            db.HiredPersons.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}