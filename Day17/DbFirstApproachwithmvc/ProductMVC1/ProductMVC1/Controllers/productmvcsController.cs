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
    public class productmvcsController : Controller
    {
        private productdatabaseEntities2 db = new productdatabaseEntities2();

        // GET: productmvcs
        public ActionResult Index()
        {
            var productmvcs = db.productmvcs.Include(p => p.categorymvc);
            return View(productmvcs.ToList());
        }

        // GET: productmvcs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            productmvc productmvc = db.productmvcs.Find(id);
            if (productmvc == null)
            {
                return HttpNotFound();
            }
            return View(productmvc);
        }

        // GET: productmvcs/Create
        public ActionResult Create()
        {
            ViewBag.catid = new SelectList(db.categorymvcs, "catid", "catname");
            return View();
        }

        // POST: productmvcs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "catid,prodid,prodname,proddesc")] productmvc productmvc)
        {
            if (ModelState.IsValid)
            {
                db.productmvcs.Add(productmvc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.catid = new SelectList(db.categorymvcs, "catid", "catname", productmvc.catid);
            return View(productmvc);
        }

        // GET: productmvcs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            productmvc productmvc = db.productmvcs.Find(id);
            if (productmvc == null)
            {
                return HttpNotFound();
            }
            ViewBag.catid = new SelectList(db.categorymvcs, "catid", "catname", productmvc.catid);
            return View(productmvc);
        }

        // POST: productmvcs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "catid,prodid,prodname,proddesc")] productmvc productmvc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productmvc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.catid = new SelectList(db.categorymvcs, "catid", "catname", productmvc.catid);
            return View(productmvc);
        }

        // GET: productmvcs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            productmvc productmvc = db.productmvcs.Find(id);
            if (productmvc == null)
            {
                return HttpNotFound();
            }
            return View(productmvc);
        }

        // POST: productmvcs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            productmvc productmvc = db.productmvcs.Find(id);
            db.productmvcs.Remove(productmvc);
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
