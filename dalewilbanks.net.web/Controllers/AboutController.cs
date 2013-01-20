using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dalewilbanks.net.wordpress;

namespace dalewilbanks.net.web.Controllers
{
    public class AboutController : Controller
    {
        WordPressReader _wpReader = new WordPressReader("http://dalewilbanks.wordpress.com/feed/");

        public ActionResult Index()
        {
            string viewName = "About";
            ViewBag.Title = "About Dale";
            ViewBag.Content = _wpReader.Read(viewName);
            return View(viewName);
        }

    }
}
