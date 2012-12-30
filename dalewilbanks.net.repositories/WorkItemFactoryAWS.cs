using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon;
using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;
using Amazon.S3;
using Amazon.S3.Model;

using dalewilbanks.net.entities;


namespace dalewilbanks.net.factories
{
    //TODO: Add Exception Handling and doublecheck for finalizers
    public class WorkItemFactoryAWS
    {
        private AmazonSimpleDB sdb;

        public WorkItemFactoryAWS(string awsAccessKey, string awsSecretKey)
        {
            sdb = AWSClientFactory.CreateAmazonSimpleDBClient(awsAccessKey, awsSecretKey);
        }

        
        public List<WorkItem> GetWorkItems()
        {
            String selectExpression = "Select * From WorkItems";
            SelectRequest selectRequestAction = new SelectRequest().WithSelectExpression(selectExpression);
            SelectResponse selectResponse = sdb.Select(selectRequestAction);

            if (!selectResponse.IsSetSelectResult()) { throw new ApplicationException("No Select Result"); }

            SelectResult selectResult = selectResponse.SelectResult;

            var list = new List<WorkItem>();

            foreach(Item item in selectResult.Item)
            {
                int id = 0;   
                Int32.TryParse(item.Name, out id);

                var workItem = new WorkItem() { WorkItemID = id };

                foreach (Amazon.SimpleDB.Model.Attribute attribute in item.Attribute)
                {
                        //TODO: Break this out into a method that accepts an attribute and a workItem
                       switch (attribute.Name)
                       {
                           case "Name":
                               workItem.Name = attribute.Value;
                               break;

                           case "Type":
                               workItem.Type = attribute.Value;
                               break;

                           case "Description":
                               workItem.Description = attribute.Value;
                               break;

                           case "Attachments":
                               workItem.Attachments = attribute.Value;
                               break;

                           case "EntryDate":
                               workItem.EntryDate = attribute.Value;
                               break;

                           case "EnteredBy":
                               workItem.EnteredBy = attribute.Value;
                               break;
                       }
                   }//end foreach attribute

                list.Add(workItem);
            }//end foreach item

            return list;

        }//end method


        //Need to break out the deserialization into it's own method to make this DRY
        public WorkItem GetWorkItem(int id)
        {
            GetAttributesRequest gar = new GetAttributesRequest();
            gar.DomainName = "WorkItems";
            gar.ItemName = id.ToString(); 
            GetAttributesResponse response = sdb.GetAttributes(gar);

            var workItem = new WorkItem() { WorkItemID = id };

            foreach (Amazon.SimpleDB.Model.Attribute attribute in response.GetAttributesResult.Attribute)
            {
                switch (attribute.Name)
                {
                    case "Name":
                        workItem.Name = attribute.Value;
                        break;

                    case "Type":
                        workItem.Type = attribute.Value;
                        break;

                    case "Description":
                        workItem.Description = attribute.Value;
                        break;

                    case "Attachments":
                        workItem.Attachments = attribute.Value;
                        break;

                    case "EntryDate":
                        workItem.EntryDate = attribute.Value;
                        break;

                    case "EnteredBy":
                        workItem.EnteredBy = attribute.Value;
                        break;
                }
            }

            return workItem;
        }

        //TODO: Add Exception Handling and Logging
        public void Save(WorkItem workItem)
        {
            String itemName = workItem.WorkItemID.ToString();

            PutAttributesRequest putAttributesAction = new PutAttributesRequest().WithDomainName("WorkItems").WithItemName(itemName);
            List<ReplaceableAttribute> attributesOne = putAttributesAction.Attribute;
            attributesOne.Add(new ReplaceableAttribute().WithName("Name").WithValue(workItem.Name));
            attributesOne.Add(new ReplaceableAttribute().WithName("Type").WithValue(workItem.Type));
            attributesOne.Add(new ReplaceableAttribute().WithName("Description").WithValue(workItem.Description));
            attributesOne.Add(new ReplaceableAttribute().WithName("Attachments").WithValue(workItem.Attachments));
            attributesOne.Add(new ReplaceableAttribute().WithName("EntryDate").WithValue(workItem.EntryDate));
            attributesOne.Add(new ReplaceableAttribute().WithName("EnteredBy").WithValue(workItem.EnteredBy));

            sdb.PutAttributes(putAttributesAction);

        }
    }
}
