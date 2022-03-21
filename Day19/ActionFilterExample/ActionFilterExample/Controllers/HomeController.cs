using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
        
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [OutputCache(Duration =10)]
        public ActionResult Index(FormCollection Collection)
        {
            ViewBag.Username = Collection["name"];
            return View();
        }
        [HandleError]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            int a = 10, b = 0;
            int c = a / b;
            RedirectToAction("/Home/About/c");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}