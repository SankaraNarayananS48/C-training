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
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    public class prodinfoesController : ApiController
    {
        private productdatabaseEntities1 db = new productdatabaseEntities1();

        // GET: api/prodinfoes
        public IQueryable<prodinfo> Getprodinfoes()
        {
            return db.prodinfoes;
        }

        // GET: api/prodinfoes/5
        [ResponseType(typeof(prodinfo))]
        public IHttpActionResult Getprodinfo(int id)
        {
            prodinfo prodinfo = db.prodinfoes.Find(id);
            if (prodinfo == null)
            {
                return NotFound();
            }

            return Ok(prodinfo);
        }

        // PUT: api/prodinfoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putprodinfo(int id, prodinfo prodinfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prodinfo.prodid)
            {
                return BadRequest();
            }

            db.Entry(prodinfo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!prodinfoExists(id))
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

        // POST: api/prodinfoes
        [ResponseType(typeof(prodinfo))]
        public IHttpActionResult Postprodinfo(prodinfo prodinfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.prodinfoes.Add(prodinfo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = prodinfo.prodid }, prodinfo);
        }

        // DELETE: api/prodinfoes/5
        [ResponseType(typeof(prodinfo))]
        public IHttpActionResult Deleteprodinfo(int id)
        {
            prodinfo prodinfo = db.prodinfoes.Find(id);
            if (prodinfo == null)
            {
                return NotFound();
            }

            db.prodinfoes.Remove(prodinfo);
            db.SaveChanges();

            return Ok(prodinfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool prodinfoExists(int id)
        {
            return db.prodinfoes.Count(e => e.prodid == id) > 0;
        }
    }
}