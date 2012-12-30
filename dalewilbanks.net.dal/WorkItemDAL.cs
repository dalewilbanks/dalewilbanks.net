using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using dalewilbanks.net.entities;
using System.Configuration;
using System.Data.SqlClient;

namespace dalewilbanks.net.DAL
{
    //This DAL layer provides a direct mapping to the underlying stored procedures.  This creates semantic coupling between the Factory and the Sprocs, but that's ok for our use, we are going to accept that.
    public class WorkItemDAL
    {
        private string connectionString;

        public WorkItemDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //TODO: Pass in the data connection in constructor, so that all of this stuff can be Unit Tested with a Mock
        //
        //DTW 2/22: Am making the method names identical to the sproc names.  I'm returning a DataTable instead of a DataReader to reduce coupling between layers.
        //My rule of thumb is that all IDisposable objects must be closed in the scope they are called in. If they work in a using statement, then you are keeping them in the correct scope and following best practice.
        public DataTable WorkItem_Get(int workItemId)
        {
            using(var cnn = new SqlConnection(this.connectionString))
            {
                cnn.Open();

                using(var cmd = new SqlCommand("WorkItem_Get", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure; //without this, your parameters aren't passed!
                    cmd.Parameters.Add(new SqlParameter("WorkItemId", workItemId));

                    var adapter = new SqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }


    }
}
