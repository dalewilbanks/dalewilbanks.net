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
            string viewName = "BestPractices";
            ViewBag.Title = "Best Practices";
            ViewBag.Content = _wpReader.Read(viewName);
            return View(viewName);
        }

        public ActionResult Methodology()
        {
            string viewName = "Methodology";
            ViewBag.Title = viewName;
            ViewBag.Content = _wpReader.Read(viewName);
            return View(viewName);
        }

        public ActionResult Usability()
        {
            string viewName = "Usability";
            ViewBag.Title = "Usability Commandments";
            ViewBag.Content = _wpReader.Read(viewName);
            return View(viewName);
        }


        public ActionResult DesignPatterns()
        {
            string viewName = "DesignPatterns";
            ViewBag.Title = "Design Patterns";
            ViewBag.Content = _wpReader.Read(viewName);
            return View(viewName);
        }

    }
}
