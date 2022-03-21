using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using ProductMVC.Models;

namespace ProductMVC.Controllers
{
    public class productinfoController : Controller
    {
        // GET: productinfo
        public ActionResult Index()
        {
            IEnumerable<productinfo> productinfoes;
            HttpResponseMessage response = globalvariable.http.GetAsync("prodinfoes").Result;
            productinfoes = response.Content.ReadAsAsync<IEnumerable<productinfo>>().Result;
            return View(productinfoes);
        }

        // GET: productinfo/Details/5
        public ActionResult Details(int? id)
        {
            productinfo productinfoes;
            HttpResponseMessage response = globalvariable.http.GetAsync("prodinfoes/"+ id ).Result;
            productinfoes = response.Content.ReadAsAsync<productinfo>().Result;
            return View(productinfoes);
     
        }

        // GET: productinfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: productinfo/Create
        [HttpPost]
        public ActionResult Create(productinfo product)
        {
            try
            {
                // TODO: Add insert logic here
                HttpResponseMessage response = globalvariable.http.PostAsJsonAsync("prodinfoes/",product).Result;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: productinfo/Edit/5
        public ActionResult Edit(int id)
        {
            productinfo productinfoes;
            HttpResponseMessage response = globalvariable.http.GetAsync("prodinfoes/" + id).Result;
            productinfoes = response.Content.ReadAsAsync<productinfo>().Result;
            return View(productinfoes);
        }

        // POST: productinfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, productinfo product)
        {
            try
            {
                // TODO: Add update logic here
                HttpResponseMessage response = globalvariable.http.PutAsJsonAsync("prodinfoes/"+id, product).Result;
                TempData["Message"] = "Updated";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: productinfo/Delete/5
        public ActionResult Delete(int id)
        {
            productinfo productinfoes;
            HttpResponseMessage response = globalvariable.http.GetAsync("prodinfoes/" + id).Result;
            productinfoes = response.Content.ReadAsAsync<productinfo>().Result;
            return View(productinfoes);
        }

        // POST: productinfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                HttpResponseMessage response = globalvariable.http.DeleteAsync("prodinfoes/" + id).Result;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
