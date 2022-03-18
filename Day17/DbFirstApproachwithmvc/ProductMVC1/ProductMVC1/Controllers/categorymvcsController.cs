using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProductMVC1.Models;

namespace ProductMVC1.Controllers
{
    public class categorymvcsController : Controller
    {
        private productdatabaseEntities db = new productdatabaseEntities();

        // GET: categorymvcs
        public ActionResult Index()
        {
            return View(db.categorymvcs.ToList());
        }

        // GET: categorymvcs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorymvc categorymvc = db.categorymvcs.Find(id);
            if (categorymvc == null)
            {
                return HttpNotFound();
            }
            return View(categorymvc);
        }

        // GET: categorymvcs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: categorymvcs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "catid,catname,catdesc")] categorymvc categorymvc)
        {
            if (ModelState.IsValid)
            {
                db.categorymvcs.Add(categorymvc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categorymvc);
        }

        // GET: categorymvcs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorymvc categorymvc = db.categorymvcs.Find(id);
            if (categorymvc == null)
            {
                return HttpNotFound();
            }
            return View(categorymvc);
        }

        // POST: categorymvcs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "catid,catname,catdesc")] categorymvc categorymvc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categorymvc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categorymvc);
        }

        // GET: categorymvcs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorymvc categorymvc = db.categorymvcs.Find(id);
            if (categorymvc == null)
            {
                return HttpNotFound();
            }
            return View(categorymvc);
        }

        // POST: categorymvcs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            categorymvc categorymvc = db.categorymvcs.Find(id);
            db.categorymvcs.Remove(categorymvc);
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
