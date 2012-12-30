using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dalewilbanks.net.entities;

namespace dalewilbanks.net.Controllers
{
    public class MVC4DemoController : Controller
    {
        private WorkItemContext db = new WorkItemContext();

        //
        // GET: /MVC4Demo/

        public ViewResult Index(int start = 0, int itemsPerPage = 20, string orderBy = "WorkItemID", bool desc = false)
        {
            ViewBag.Count = db.WorkItems.Count();
            ViewBag.Start = start;
            ViewBag.ItemsPerPage = itemsPerPage;
            ViewBag.OrderBy = orderBy;
            ViewBag.Desc = desc;

            return View("MVC4Demo");
        }

        //
        // GET: /MVC4Demo/GridData/?start=0&itemsPerPage=20&orderBy=WorkItemID&desc=true

        public ActionResult GridData(int start = 0, int itemsPerPage = 20, string orderBy = "WorkItemID", bool desc = false)
        {
            Response.AppendHeader("X-Total-Row-Count", db.WorkItems.Count().ToString());
            ObjectQuery<WorkItem> workitems = (db as IObjectContextAdapter).ObjectContext.CreateObjectSet<WorkItem>();
            workitems = workitems.OrderBy("it." + orderBy + (desc ? " desc" : ""));

            return PartialView(workitems.Skip(start).Take(itemsPerPage));
        }

        //
        // GET: /Default5/RowData/5

        public ActionResult RowData(int id)
        {
            WorkItem workitem = db.WorkItems.Find(id);
            return PartialView("GridData", new WorkItem[] { workitem });
        }

        //
        // GET: /MVC4Demo/Create

        public ActionResult Create()
        {
            return PartialView("Edit");
        }

        //
        // POST: /MVC4Demo/Create

        [HttpPost]
        public ActionResult Create(WorkItem workitem)
        {
            if (ModelState.IsValid)
            {
                db.WorkItems.Add(workitem);
                db.SaveChanges();
                return PartialView("GridData", new WorkItem[] { workitem });
            }

            return PartialView("Edit", workitem);
        }

        //
        // GET: /MVC4Demo/Edit/5

        public ActionResult Edit(int id)
        {
            WorkItem workitem = db.WorkItems.Find(id);
            return PartialView(workitem);
        }

        //
        // POST: /MVC4Demo/Edit/5

        [HttpPost]
        public ActionResult Edit(WorkItem workitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workitem).State = EntityState.Modified;
                db.SaveChanges();
                return PartialView("GridData", new WorkItem[] { workitem });
            }

            return PartialView(workitem);
        }

        //
        // POST: /MVC4Demo/Delete/5

        [HttpPost]
        public void Delete(int id)
        {
            WorkItem workitem = db.WorkItems.Find(id);
            db.WorkItems.Remove(workitem);
            db.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
