using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ValidationAttribute.Models;

namespace ValidationAttribute.Controllers
{
    public class HiredPersonsController : Controller
    {
        private myDB_SQLEntities db = new myDB_SQLEntities();

        // GET: HiredPersons
        public ActionResult Index()
        {
            return View(db.HiredPersons.ToList());
        }

        // GET: HiredPersons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HiredPerson hiredPerson = db.HiredPersons.Find(id);
            if (hiredPerson == null)
            {
                return HttpNotFound();
            }
            return View(hiredPerson);
        }

        // GET: HiredPersons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HiredPersons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,fullname,Gender,Age,EmailAddress,Doj,Salary")] HiredPerson hiredPerson)
        {
            if (ModelState.IsValid)
            {
                db.HiredPersons.Add(hiredPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hiredPerson);
        }

        // GET: HiredPersons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HiredPerson hiredPerson = db.HiredPersons.Find(id);
            if (hiredPerson == null)
            {
                return HttpNotFound();
            }
            return View(hiredPerson);
        }

        // POST: HiredPersons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,fullname,Gender,Age,EmailAddress,Doj,Salary")] HiredPerson hiredPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hiredPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hiredPerson);
        }

        // GET: HiredPersons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HiredPerson hiredPerson = db.HiredPersons.Find(id);
            if (hiredPerson == null)
            {
                return HttpNotFound();
            }
            return View(hiredPerson);
        }

        // POST: HiredPersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HiredPerson hiredPerson = db.HiredPersons.Find(id);
            db.HiredPersons.Remove(hiredPerson);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
