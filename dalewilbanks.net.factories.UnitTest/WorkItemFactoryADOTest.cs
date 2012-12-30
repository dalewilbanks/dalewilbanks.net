using dalewilbanks.net.factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using dalewilbanks.net.entities;
using System.Collections.Generic;
using System.Data;

namespace dalewilbanks.net.factories.UnitTest
{
    
    
    /// <summary>
    ///This is a test class for WorkItemFactoryADOTest and is intended
    ///to contain all WorkItemFactoryADOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WorkItemFactoryADOTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for WorkItemFactoryADO Constructor
        ///</summary>
        [TestMethod()]
        public void WorkItemFactoryADOConstructorTest()
        {
            string connectionString = string.Empty; // TODO: Initialize to an appropriate value
            WorkItemFactoryADO target = new WorkItemFactoryADO(connectionString);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            string connectionString = string.Empty; // TODO: Initialize to an appropriate value
            WorkItemFactoryADO target = new WorkItemFactoryADO(connectionString); // TODO: Initialize to an appropriate value
            int workItemId = 0; // TODO: Initialize to an appropriate value
            target.Delete(workItemId);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            string connectionString = string.Empty; // TODO: Initialize to an appropriate value
            WorkItemFactoryADO target = new WorkItemFactoryADO(connectionString); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            WorkItem expected = null; // TODO: Initialize to an appropriate value
            WorkItem actual;
            actual = target.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest()
        {
            string connectionString = string.Empty; // TODO: Initialize to an appropriate value
            WorkItemFactoryADO target = new WorkItemFactoryADO(connectionString); // TODO: Initialize to an appropriate value
            List<WorkItem> expected = null; // TODO: Initialize to an appropriate value
            List<WorkItem> actual;
            actual = target.GetList();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HydrateWorkItem
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dalewilbanks.net.factories.dll")]
        public void HydrateWorkItemTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            WorkItemFactoryADO_Accessor target = new WorkItemFactoryADO_Accessor(param0); // TODO: Initialize to an appropriate value
            DataRow dataRow = null; // TODO: Initialize to an appropriate value
            WorkItem expected = null; // TODO: Initialize to an appropriate value
            WorkItem actual;
            actual = target.HydrateWorkItem(dataRow);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            string connectionString = string.Empty; // TODO: Initialize to an appropriate value
            WorkItemFactoryADO target = new WorkItemFactoryADO(connectionString); // TODO: Initialize to an appropriate value
            WorkItem workItem = null; // TODO: Initialize to an appropriate value
            target.Save(workItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
