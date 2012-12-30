using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using dalewilbanks.net.entities;
using dalewilbanks.net.DAL;


namespace dalewilbanks.net.factories
{
    public class WorkItemFactoryADO
    {
        private string connectionString;

        public WorkItemFactoryADO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        #region Public Methods
        public WorkItem Get(int id)
        {
            var workItemFactory = new WorkItemDAL(this.connectionString);
            
            var dataTable = workItemFactory.WorkItem_Get(id);

            if (dataTable == null)
            {
                throw new ApplicationException("WorkItem_Get returned null instead of a DataTable");
            }
            else if (dataTable.Rows.Count < 1)
            {
                throw new ApplicationException("Not enough DataRows returned by WorkItem_Get");
            }
            else if (dataTable.Rows.Count > 1)
            {
                throw new ApplicationException("Too many DataRows returned by WorkItem_Get");
            }
            else
            {
                return HydrateWorkItem(dataTable.Rows[0]);
            }
        }

        public List<WorkItem> GetList()
        {
            throw new NotImplementedException();

        }

        public void Save(WorkItem workItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int workItemId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Private Methods
        private WorkItem HydrateWorkItem(DataRow dataRow)
        {
            var wi = new WorkItem();

            wi.WorkItemID = (int)dataRow["WorkItemId"];
            wi.Name = (string)dataRow["Name"];
            wi.Description = (string)dataRow["Description"];

            return wi;
        }
        #endregion

    }
}
