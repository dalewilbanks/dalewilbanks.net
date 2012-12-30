using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dalewilbanks.net.web.Controllers
{
    public class CSS3AnimationController : Controller
    {
        //
        // GET: /CSS3Animation/

        public ActionResult Index()
        {
            return View("CSS3Animation");
        }

        //
        // GET: /CSS3Animation/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /CSS3Animation/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CSS3Animation/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /CSS3Animation/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CSS3Animation/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /CSS3Animation/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CSS3Animation/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
