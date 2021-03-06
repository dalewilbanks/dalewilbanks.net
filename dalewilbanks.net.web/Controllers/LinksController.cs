﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dalewilbanks.net.wordpress;

namespace dalewilbanks.net.web.Controllers
{
    public class LinksController : Controller
    {
        WordPressReader _wpReader = new WordPressReader("http://dalewilbanks.wordpress.com/feed/");

        public ActionResult Index()
        {
            string viewName = "Links";
            ViewBag.Title = "Technology Links - some of the resources I find amazingly helpful";
            ViewBag.Content = _wpReader.Read(viewName);
            return View(viewName);
        }

    }
}
