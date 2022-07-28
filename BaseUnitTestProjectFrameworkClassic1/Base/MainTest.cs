using BaseUnitTestProjectFrameworkClassic1.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace BaseUnitTestProjectFrameworkClassic1
{
    public partial class MainTest
    {


        /// <summary>
        /// Perform initialization before each test runs
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            //if (TestContext.TestName == nameof(TestMethod1))
            //{

            //}


        }
        [TestCleanup]
        public void TestCleanup()
        {

            //if (TestContext.TestName == nameof(TestMethod1))
            //{

            //}

        }
        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
    }

}
