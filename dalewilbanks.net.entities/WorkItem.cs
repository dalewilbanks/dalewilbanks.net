using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dalewilbanks.net.entities
{
    //TODO: Get the types right and encapsulate as properties */
    public class WorkItem
    {
        public int WorkItemID { get; set; }
        public string Name { get; set; }
        //TODO: Replace this with an enum
        public string Type { get; set; }
        public string Description { get; set; }
        public string Attachments { get; set; }
        //TODO: change type to DateTime
        public string EntryDate { get; set; }
        public string EnteredBy { get; set; }

        //implement a values based equality
        public bool Equals(WorkItem w)
        {
            return
                    (this.WorkItemID == w.WorkItemID) &&
                    (this.Name == w.Name) &&
                    (this.Description == w.Description);
        }

        
    }
}
