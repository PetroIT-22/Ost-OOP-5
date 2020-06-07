using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Ost_OOP_5.Site.Ser();
            Assert.AreEqual(6, result);
        }
    }
}
