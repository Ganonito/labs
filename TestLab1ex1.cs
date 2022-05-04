using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int N = 550;
            double result = Lab1ex1.Program.Example(x);
            Assert.AreEqual(9, result);
        }
    }
}
