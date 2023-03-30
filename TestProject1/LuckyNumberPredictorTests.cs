using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class LuckyNumberPredictorTests
    {
        [TestMethod]
        public void GetYourLuckyNumberTest()
        {
            Assert.AreEqual(24157817, LuckyNumberPredictor.GetYourLuckyNumber(20, 3, 2001));
        }

       
    }
}
