using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FormValidation.Models;

namespace FormValidation.Controllers
{
    public class prodinfoesController : Controller
    {
        private productdatabaseEntities2 db = new productdatabaseEntities2();

        // GET: prodinfoes
        public ActionResult Index()
        {
            return View(db.prodinfoes.ToList());
        }

        // GET: prodinfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prodinfo prodinfo = db.prodinfoes.Find(id);
            if (prodinfo == null)
            {
                return HttpNotFound();
            }
            return View(prodinfo);
        }

        // GET: prodinfoes/Create
        [ActionName("Createproduct")]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: prodinfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Createproduct")]
        public ActionResult Create([Bind(Include = "prodid,prodname,quantity,proddesc")] prodinfo prodinfo)
        {
            if (ModelState.IsValid)
            {
                db.prodinfoes.Add(prodinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prodinfo);
        }

        // GET: prodinfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prodinfo prodinfo = db.prodinfoes.Find(id);
            if (prodinfo == null)
            {
                return HttpNotFound();
            }
            return View(prodinfo);
        }

        // POST: prodinfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "prodid,prodname,quantity,proddesc")] prodinfo prodinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prodinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prodinfo);
        }

        // GET: prodinfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prodinfo prodinfo = db.prodinfoes.Find(id);
            if (prodinfo == null)
            {
                return HttpNotFound();
            }
            return View(prodinfo);
        }

        // POST: prodinfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            prodinfo prodinfo = db.prodinfoes.Find(id);
            db.prodinfoes.Remove(prodinfo);
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
