using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dalewilbanks.net.wordpress;

namespace dalewilbanks.net.web.Controllers
{
    public class HomeController : Controller
    {
        WordPressReader _wpReader = new WordPressReader("http://dalewilbanks.wordpress.com/feed/");

        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to dalewilbanks.net";
            ViewBag.Content = _wpReader.Read(ViewBag.Title);
            return View("Home");
        }

    }
}
