using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace dalewilbanks.net.entities
{
    
    public class WorkItemContext: DbContext
    {
        public DbSet<WorkItem> WorkItems { get; set; }
    }
}
