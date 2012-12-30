using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dalewilbanks.net.entities;

namespace dalewilbanks.net.web.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult WorkItemJSON()
        {
            return View("WorkItemJSON");
        }

        /*public void WorkItemAWSPost()
        {
            var wif = new dalewilbanks.net.factories.WorkItemFactoryAWS(
            System.Configuration.ConfigurationManager.AppSettings["AWSAccessKey"],
            System.Configuration.ConfigurationManager.AppSettings["AWSSecretKey"]);

            int workItemID = 0;
            Int32.TryParse(Request["WorkItemID"], out workItemID);

            if (workItemID != 0)
            {
                var workItem = new dalewilbanks.net.entities.WorkItem() { WorkItemID = workItemID, Name = Request["Name"], Type = Request["Type"], Description = Request["Description"], Attachments = Request["Attachments"], EnteredBy = Request["EnteredBy"], EntryDate = Request["EntryDate"] };
                wif.Save(workItem);
            }
        }*/

        public void WorkItemEFPost()
        {
            var workItemsContext = new WorkItemContext();

            var workItem = new dalewilbanks.net.entities.WorkItem() { Name = Request["Name"], Type = Request["Type"], Description = Request["Description"], Attachments = String.Empty, EnteredBy = Request["EnteredBy"], EntryDate = Request["EntryDate"] };
            workItemsContext.WorkItems.Add(workItem);
            workItemsContext.SaveChanges();
        }
    }
}
