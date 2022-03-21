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
using ExampleAPI.Models;

namespace ExampleAPI.Controllers
{
    public class studentregsController : ApiController
    {
        private studentEntities db = new studentEntities();

        // GET: api/studentregs
        public IQueryable<studentreg> Getstudentregs()
        {
            return db.studentregs;
        }

        // GET: api/studentregs/5
        [ResponseType(typeof(studentreg))]
        public IHttpActionResult Getstudentreg(string id)
        {
            studentreg studentreg = db.studentregs.Find(id);
            if (studentreg == null)
            {
                return NotFound();
            }

            return Ok(studentreg);
        }

        // PUT: api/studentregs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putstudentreg(string id, studentreg studentreg)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != studentreg.rollno)
            {
                return BadRequest();
            }

            db.Entry(studentreg).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!studentregExists(id))
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

        // POST: api/studentregs
        [ResponseType(typeof(studentreg))]
        public IHttpActionResult Poststudentreg(studentreg studentreg)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.studentregs.Add(studentreg);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (studentregExists(studentreg.rollno))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = studentreg.rollno }, studentreg);
        }

        // DELETE: api/studentregs/5
        [ResponseType(typeof(studentreg))]
        public IHttpActionResult Deletestudentreg(string id)
        {
            studentreg studentreg = db.studentregs.Find(id);
            if (studentreg == null)
            {
                return NotFound();
            }

            db.studentregs.Remove(studentreg);
            db.SaveChanges();

            return Ok(studentreg);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool studentregExists(string id)
        {
            return db.studentregs.Count(e => e.rollno == id) > 0;
        }
    }
}