using dalewilbanks.net.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace dalewilbanks.net.DAL.UnitTest
{
    
    
    /// <summary>
    ///This is a test class for WorkItemDALTest and is intended
    ///to contain all WorkItemDALTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WorkItemDALTest
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
        ///A test for WorkItemDAL Constructor
        ///</summary>
        [TestMethod()]
        public void WorkItemDALConstructorTest()
        {
            string connectionString = string.Empty; // TODO: Initialize to an appropriate value
            WorkItemDAL target = new WorkItemDAL(connectionString);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for WorkItem_Get
        ///</summary>
        [TestMethod()]
        public void WorkItem_GetTest()
        {
            string connectionString = string.Empty; // TODO: Initialize to an appropriate value
            WorkItemDAL target = new WorkItemDAL(connectionString); // TODO: Initialize to an appropriate value
            int workItemId = 1; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.WorkItem_Get(workItemId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
