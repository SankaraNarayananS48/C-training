using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using MVCAPIApp.Models;
using System.Net.Mail;

namespace MVCAPIApp.Controllers
{
    public class RegistrationsController : Controller
    {
        // GET: Registrations
        public ActionResult Index()
        {
            
            IEnumerable<Registration> RegDetails;
            HttpResponseMessage res = Globalvariable.webapiclient.GetAsync("Registrations").Result;
            RegDetails = res.Content.ReadAsAsync<IEnumerable<Registration>>().Result;
            return View(RegDetails);
        }
                                     
       [HttpPost]
        public ActionResult Index(Registration registration)
        {
            //IEnumerable<Registration> RegDetails;
            //HttpResponseMessage res = Globalvariable.webapiclient.GetAsync("Registrations").Result;
            //RegDetails = res.Content.ReadAsAsync<IEnumerable<Registration>>().Result;
            return View(registration);
        }

        // GET: Registrations/Details/5
        public ActionResult Details(int id)
        {
            Registration Regdetails;
            HttpResponseMessage res = Globalvariable.webapiclient.GetAsync("Registrations/"+id).Result;
            Regdetails = res.Content.ReadAsAsync<Registration>().Result;
            return View(Regdetails);
        }
        [HttpPost]
        

        // GET: Registrations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registrations/Create
        [HttpPost]
        public ActionResult Create(Registration registration)
        {
            try
            {
                // TODO: Add insert logic here

                HttpResponseMessage res = Globalvariable.webapiclient.PostAsJsonAsync("Registrations", registration).Result;

                //SendEmail();




                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Registrations/Edit/5
        public ActionResult Edit(int id)
        {
            Registration Regdetails;
            HttpResponseMessage res = Globalvariable.webapiclient.GetAsync("Registrations/" + id).Result;
            Regdetails = res.Content.ReadAsAsync<Registration>().Result;
            return View(Regdetails);
        }

        // POST: Registrations/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Registration registration)
        {
            try
            {
                // TODO: Add update logic here
                HttpResponseMessage res = Globalvariable.webapiclient.PutAsJsonAsync("Registrations/"+id, registration).Result;
                TempData["Message"] = "Updated ";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registrations/Delete/5
        public ActionResult Delete(int id)
        {
            Registration Regdetails;
            HttpResponseMessage res = Globalvariable.webapiclient.GetAsync("Registrations/" + id).Result;
            Regdetails = res.Content.ReadAsAsync<Registration>().Result;
            return View(Regdetails);

        }

        // POST: Registrations/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Registration registration)
        {
            try
            {
                // TODO: Add delete logic here
                HttpResponseMessage res = Globalvariable.webapiclient.DeleteAsync("Registrations/" + id).Result;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult DeleteMulSelect(FormCollection form)
        {

            string[] ids = form["chbox"].Split(new char[] { ','});
            foreach(var id in ids)
            { 
            HttpResponseMessage res = Globalvariable.webapiclient.DeleteAsync("Registrations/" + id).Result;
            }
            return RedirectToAction("index");
        }



    }
}
