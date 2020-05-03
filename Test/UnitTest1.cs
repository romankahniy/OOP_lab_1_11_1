using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = OOP_lab_1_11_1.Program.Main();
            Assert.AreEqual(result, 645);
        }
    }
}
