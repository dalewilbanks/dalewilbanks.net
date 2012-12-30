using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;


using dalewilbanks.net.entities;


namespace WorkItemsSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<WorkItemContext>(new CreateDatabaseIfNotExists<WorkItemContext>());

            var workItems = new WorkItemContext();

            workItems.WorkItems.Add(new WorkItem { Attachments = "none", Description = "description 2", EnteredBy = "dale wilbanks", EntryDate = DateTime.Now.ToString(), Name = "Second EF work item", Type = "Bug" });

            workItems.SaveChanges();
        }
    }
}
