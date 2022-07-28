using BaseUnitTestProjectFrameworkClassic1.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BaseUnitTestProjectFrameworkClassic1
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void TestMethod1()
        {
            Assert.IsTrue(Environment.UserName == "PayneK");
        }
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void TestMethod2()
        {
            // TODO
        }
    }
}