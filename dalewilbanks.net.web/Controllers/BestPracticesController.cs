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
            ViewBag.Content = dalewilbanks.net.wordpress.WordPressReader.Read("http://dalewilbanks.wordpress.com/feed/", "Best Practices");

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
