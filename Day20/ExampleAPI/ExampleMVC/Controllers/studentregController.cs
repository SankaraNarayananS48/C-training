using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleMVC.Models;
using System.Net.Http;

namespace ExampleMVC.Controllers
{
    public class studentregController : Controller
    {
        // GET: studentreg
        public ActionResult Index()
        {
            IEnumerable<studentreg> student;
            HttpResponseMessage response = globalvariable.http.GetAsync("studentregs").Result;
            student = response.Content.ReadAsAsync<IEnumerable<studentreg>>().Result;
            return View(student);
        }

        // GET: studentreg/Details/5
        public ActionResult Details(int? id)
        {
            studentreg student;
            HttpResponseMessage response = globalvariable.http.GetAsync("studentregs/" + id).Result;
            student = response.Content.ReadAsAsync<studentreg>().Result;
            return View(student);
        }

        // GET: studentreg/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: studentreg/Create
        [HttpPost]
        public ActionResult Create(studentreg student)
        {
            try
            {
                // TODO: Add insert logic here
                HttpResponseMessage response = globalvariable.http.PostAsJsonAsync("studregs/", student).Result;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: studentreg/Edit/5
        public ActionResult Edit(int id)
        {
            studentreg student;
            HttpResponseMessage response = globalvariable.http.GetAsync("studentregs/" + id).Result;
            student = response.Content.ReadAsAsync<studentreg>().Result;
            return View(student);
        }

        // POST: studentreg/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,studentreg student)
        {
            try
            {
                // TODO: Add update logic here
                HttpResponseMessage response = globalvariable.http.PutAsJsonAsync("studentregs/" + id, student).Result;
                TempData["Message"] = "Updated";
                return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
        }

        // GET: studentreg/Delete/5
        public ActionResult Delete(int id)
        {
            studentreg student;
            HttpResponseMessage response = globalvariable.http.GetAsync("studentregs/" + id).Result;
            student = response.Content.ReadAsAsync<studentreg>().Result;
            return View(student);
        }

        // POST: studentreg/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                HttpResponseMessage response = globalvariable.http.DeleteAsync("studentregs/" + id).Result;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
