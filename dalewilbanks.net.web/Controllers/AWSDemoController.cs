using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dalewilbanks.net.web.Controllers
{
    public class AWSDemoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index: You are on the AWSDemo page";

            return View("AWSDemo");
        }
    }
}
