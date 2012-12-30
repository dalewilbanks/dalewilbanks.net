using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dalewilbanks.net.web.Controllers
{
    public class EntityFrameworkDemoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index: You are on the EntityFramworkDemo page";

            return View("EntityFrameworkDemo");
        }
    }
}
