using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dalewilbanks.net.entities;

namespace dalewilbanks.net.web.Controllers
{ 
    public class ProtoController : Controller
    {
        private WorkItemContext db = new WorkItemContext();

        //
        // GET: /Proto/

        public ViewResult Index()
        {
            //return View(db.WorkItems.ToList());
            return View("Proto");
        }

        //
        // GET: /Proto/Details/5

        public ViewResult Details(int id)
        {
            WorkItem workitem = db.WorkItems.Find(id);
            return View(workitem);
        }

        //
        // GET: /Proto/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Proto/Create

        [HttpPost]
        public ActionResult Create(WorkItem workitem)
        {
            if (ModelState.IsValid)
            {
                db.WorkItems.Add(workitem);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(workitem);
        }
        
        //
        // GET: /Proto/Edit/5
 
        public ActionResult Edit(int id)
        {
            WorkItem workitem = db.WorkItems.Find(id);
            return View(workitem);
        }

        //
        // POST: /Proto/Edit/5

        [HttpPost]
        public ActionResult Edit(WorkItem workitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workitem);
        }

        //
        // GET: /Proto/Delete/5
 
        public ActionResult Delete(int id)
        {
            WorkItem workitem = db.WorkItems.Find(id);
            return View(workitem);
        }

        //
        // POST: /Proto/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            WorkItem workitem = db.WorkItems.Find(id);
            db.WorkItems.Remove(workitem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}