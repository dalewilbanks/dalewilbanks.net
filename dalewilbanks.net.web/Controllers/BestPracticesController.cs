using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dalewilbanks.net.web.Controllers
{
    public class BestPracticesController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View("BestPractices");
        }

        public ActionResult Methodology()
        {
            return View("Methodology");
        }

        public ActionResult Usability()
        {
            return View("Usability");
        }


        public ActionResult DesignPatterns()
        {
            return View("DesignPatterns");
        }

    }
}
