using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using dalewilbanks.net.entities;

namespace dalewilbanks.net.web.APIs.Controllers
{
    public class WorkItemController : ApiController
    {

        WorkItemContext workItemContext = new WorkItemContext();

        //GET api/WorkItem
       public IQueryable<WorkItem> Get()
       {
            return workItemContext.WorkItems;
       }

       
        //NOTE: The int parameter MUST be named id, or else this action won't map!!!
        //GET api/WorkItem/5
        public WorkItem Get(int id)
        {
            return workItemContext.WorkItems.Single(w => w.WorkItemID == id);
        }


        #region scafolded code, commented out
        
        //// GET /api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET /api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST /api/<controller>
        //public void Post(string value)
        //{
        //}

        //// PUT /api/<controller>/5
        //public void Put(int id, string value)
        //{
        //}

        //// DELETE /api/<controller>/5
        //public void Delete(int id)
        //{
        //}
        #endregion

    }
}