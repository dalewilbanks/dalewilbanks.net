using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dalewilbanks.net.wordpress;

namespace dalewilbanks.net.web.Controllers
{
    public class BestPracticesController : Controller
    {
        WordPressReader _wpReader = new WordPressReader("http://dalewilbanks.wordpress.com/feed/");

        public ActionResult Index()
        {
            ViewBag.Title = "Best Practices";
            ViewBag.Content = _wpReader.Read(ViewBag.Title);
            return View("BestPractices");
        }

        public ActionResult Methodology()
        {
            ViewBag.Title = "Methodology";
            ViewBag.Content = _wpReader.Read(ViewBag.Title);
            return View("Methodology");
        }

        public ActionResult Usability()
        {
            ViewBag.Title = "Usability Commandments";
            ViewBag.Content = _wpReader.Read(ViewBag.Title);
            return View("Usability");
        }


        public ActionResult DesignPatterns()
        {
            ViewBag.Title = "Design Patterns";
            ViewBag.Content = _wpReader.Read(ViewBag.Title);
            return View("DesignPatterns");
        }

    }
}
