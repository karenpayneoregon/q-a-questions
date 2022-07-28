using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ReSharper disable once CheckNamespace - do not change
namespace BaseUnitTestProject1
{
    public partial class MainTest : IDisposable
    {

        public MainTest()
        {
            Console.WriteLine($"New constructor for {nameof(MainTest)}");
        }

        /// <summary>
        /// Perform initialization before each test runs
        /// </summary>
        /// <returns>Nothing we care about</returns>
        /// <remarks>
        /// For synchronous preparation
        /// * Remove the async modifier
        /// * Remove the line with await Task.Delay(0);
        /// </remarks>
        [TestInitialize]
        public async Task Init()
        {
            if (TestContext.TestName == "TestMethod1")
            {
                await Task.Delay(0);
                Console.WriteLine("Called before TestMethod1");
            }
        }
        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName == "TestMethod1")
            {
                Console.WriteLine($"TestCleanup: {TestContext.TestName}");
            }
            else
            {
                Console.WriteLine("In test cleanup but don't care what test it is.");
            }

        }
        /// <summary>
        /// Perform any initialize for the class
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
        /// <summary>
        /// Here is where any clean operations are performed for this class
        /// </summary>
        /// <returns></returns>
        [ClassCleanup()]
        public static async Task ClassCleanup()
        {
            await Task.Delay(0);
        }
        /// <summary>
        /// Optional event to clean up any objects that are not managed by the framework
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine($"Disposing at {DateTime.Now:hh:mm:ss:fff}");
        }
    }

}
