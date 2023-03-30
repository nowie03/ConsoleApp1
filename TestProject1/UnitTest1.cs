using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(UnitTestingTry.Method1(2, 3) ==50);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.ThrowsException<NotImplementedException>(()=>UnitTestingTry.Method2());
        }
    }
}