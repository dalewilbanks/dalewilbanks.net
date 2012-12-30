using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using dalewilbanks.net.entities;

namespace dalewilbanks.net.services
{
    // Start the service and browse to http://<machine_name>:<port>/Service1/help to view the service's generated help page
    // NOTE: By default, a new instance of the service is created for each call; change the InstanceContextMode to Single if you want
    // a single instance of the service to process all calls.	
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    // NOTE: If the service is renamed, remember to update the global.asax.cs file
    public class WorkItemEFService
    {
        // TODO: Implement the collection resource that will contain the WorkItem instances

        [WebGet(UriTemplate = "")]
        public List<WorkItem> GetCollection()  //changed return type to IEnumerable<WorkItem> from List<WorkItem>, doesn't seem to be liked by WCF service though
        {

            var workItemContext = new WorkItemContext();

            //added this copy as a workaround
            var workItems = new List<WorkItem>();

            foreach (WorkItem workItem in workItemContext.WorkItems)
            {
                workItems.Add(workItem);
            }

            return workItems;
        }

        [WebInvoke(UriTemplate = "", Method = "POST")]
        public WorkItem Create(WorkItem instance)
        {
            // TODO: Add the new instance of WorkItem to the collection
            throw new NotImplementedException();
        }

        [WebGet(UriTemplate = "{id}")]
        public WorkItem Get(string id)
        {
            // TODO: Return the instance of WorkItem with the given id
            throw new NotImplementedException();
        }

        [WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        public WorkItem Update(string id, WorkItem instance)
        {
            // TODO: Update the given instance of WorkItem in the collection
            throw new NotImplementedException();
        }

        [WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        public void Delete(string id)
        {
            // TODO: Remove the instance of WorkItem with the given id from the collection
            throw new NotImplementedException();
        }

    }
}
