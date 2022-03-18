using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to Product Validation";
            TempData["Messages"] = "Temp data message";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your Product description page.";
            TempData.Keep("Messages");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your Product contact page.";
            TempData.Keep("Messages");
            return View();
        }
    }
}