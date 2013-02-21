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
            return View("1-CSSConcepts/CSSConcepts");
        }

        public ActionResult PrototypeLayout()
        {
            return View("2-PrototypeLayout/PrototypeLayout");
        }

        public ActionResult KnowYourTools()
        {
            return View("3-KnowYourTools/KnowYourTools");
        }

        public ActionResult MaintainableCSS()
        {
            return View("4-MaintainableCSS/MaintainableCSS");
        }

        public ActionResult GraphicsAndColorScheme()
        {
            return View("5-GraphicsAndColorScheme/GraphicsAndColorScheme");
        }

        public ActionResult DefineStyles()
        {
            return View("6-DefineStyles/DefineStyles");
        }

        public ActionResult AdvancedCSS3Effects()
        {
            return View("7-AdvancedCSS3Effects/AdvancedCSS3Effects");
        }
    }
}
