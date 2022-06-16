using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Base;

namespace UnitTestProject1
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void TestMethod1()
        {
            Assert.IsNull(null);
        }
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void TestMethod2()
        {
            Assert.IsNull(null);
        }
    }
}
