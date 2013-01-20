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
            ViewBag.Content = dalewilbanks.net.wordpress.WordPressReader.Read("http://dalewilbanks.wordpress.com/feed/", "Methodology");
            return View("Methodology");
        }

        public ActionResult Usability()
        {
            ViewBag.Content = dalewilbanks.net.wordpress.WordPressReader.Read("http://dalewilbanks.wordpress.com/feed/", "Usability");
            return View("Usability");
        }


        public ActionResult DesignPatterns()
        {
            ViewBag.Content = dalewilbanks.net.wordpress.WordPressReader.Read("http://dalewilbanks.wordpress.com/feed/", "Design Patterns");
            return View("DesignPatterns");
        }

    }
}
