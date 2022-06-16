using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


// ReSharper disable once CheckNamespace - do not change
namespace UnitTestProject1
{
    public partial class MainTest
    {

        private static readonly List<DateTime> _dateTimes = new();

        [TestInitialize]
        public void Initialization()
        {
            if (TestContext.TestName is nameof(TestMethod1))
            {
                _dateTimes.Add(DateTime.Now);
                Console.WriteLine($"{nameof(Initialization)}, {_dateTimes.Count}");
            }else if (TestContext.TestName is nameof(TestMethod2))
            {
                _dateTimes.AddRange(new []{DateTime.Now, DateTime.Now.AddSeconds(2)});
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine($"{nameof(TestCleanup)}, {_dateTimes.Count}");
        }

        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
            Console.WriteLine($"{nameof(ClassInitialize)}, {_dateTimes.Count}");
        }
    }
}
