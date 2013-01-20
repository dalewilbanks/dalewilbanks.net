using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dalewilbanks.net.web.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Content = dalewilbanks.net.wordpress.WordPressReader.Read("http://dalewilbanks.wordpress.com/feed/", "About Dale");

            return View("About");
        }

    }
}
