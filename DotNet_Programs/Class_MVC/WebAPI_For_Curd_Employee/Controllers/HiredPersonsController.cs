using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI_For_Curd_Employee.Models;

namespace WebAPI_For_Curd_Employee.Controllers
{
    public class HiredPersonsController : ApiController
    {
        private myDB_SQLEntities db = new myDB_SQLEntities();

        // GET: api/HiredPersons
        public IQueryable<HiredPerson> GetHiredPersons()
        {
            return db.HiredPersons;
        }

        // GET: api/HiredPersons/5
        [ResponseType(typeof(HiredPerson))]
        public IHttpActionResult GetHiredPerson(int id)
        {
            HiredPerson hiredPerson = db.HiredPersons.Find(id);
            if (hiredPerson == null)
            {
                return NotFound();
            }

            return Ok(hiredPerson);
        }

        // PUT: api/HiredPersons/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHiredPerson(int id, HiredPerson hiredPerson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hiredPerson.ID)
            {
                return BadRequest();
            }

            db.Entry(hiredPerson).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HiredPersonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/HiredPersons
        [ResponseType(typeof(HiredPerson))]
        public IHttpActionResult PostHiredPerson(HiredPerson hiredPerson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HiredPersons.Add(hiredPerson);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HiredPersonExists(hiredPerson.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hiredPerson.ID }, hiredPerson);
        }

        // DELETE: api/HiredPersons/5
        [ResponseType(typeof(HiredPerson))]
        public IHttpActionResult DeleteHiredPerson(int id)
        {
            HiredPerson hiredPerson = db.HiredPersons.Find(id);
            if (hiredPerson == null)
            {
                return NotFound();
            }

            db.HiredPersons.Remove(hiredPerson);
            db.SaveChanges();

            return Ok(hiredPerson);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HiredPersonExists(int id)
        {
            return db.HiredPersons.Count(e => e.ID == id) > 0;
        }
    }
}