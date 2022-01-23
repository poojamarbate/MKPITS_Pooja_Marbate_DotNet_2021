using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Example1.Models;

namespace MVC_Example1.Controllers
{
    public class Grocery_ProductController : Controller
    {
        private myDB_SQLEntities db = new myDB_SQLEntities();

        // GET: Grocery_Product
        public ActionResult Index()
        {
            return View(db.Grocery_Product.ToList());
        }

        // GET: Grocery_Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grocery_Product grocery_Product = db.Grocery_Product.Find(id);
            if (grocery_Product == null)
            {
                return HttpNotFound();
            }
            return View(grocery_Product);
        }

        // GET: Grocery_Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grocery_Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Productname,Price,mfd,Catid")] Grocery_Product grocery_Product)
        {
            if (ModelState.IsValid)
            {
                db.Grocery_Product.Add(grocery_Product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grocery_Product);
        }

        // GET: Grocery_Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grocery_Product grocery_Product = db.Grocery_Product.Find(id);
            if (grocery_Product == null)
            {
                return HttpNotFound();
            }
            return View(grocery_Product);
        }

        // POST: Grocery_Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Productname,Price,mfd,Catid")] Grocery_Product grocery_Product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grocery_Product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grocery_Product);
        }

        // GET: Grocery_Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grocery_Product grocery_Product = db.Grocery_Product.Find(id);
            if (grocery_Product == null)
            {
                return HttpNotFound();
            }
            return View(grocery_Product);
        }

        // POST: Grocery_Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grocery_Product grocery_Product = db.Grocery_Product.Find(id);
            db.Grocery_Product.Remove(grocery_Product);
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
