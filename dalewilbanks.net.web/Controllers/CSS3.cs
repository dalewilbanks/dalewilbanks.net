using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dalewilbanks.net.web.Controllers
{
    public class CSS3Controller : Controller
    {
        //
        // GET: /CSS3/

        public ActionResult Index()
        {
            return View("CSS3");
        }

        public ActionResult CSSConcepts()
        {
            return View("CSSConcepts");
        }
    }
}
