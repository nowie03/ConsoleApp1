using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class WorkingNineToFiveTests
    {
        [TestMethod]
        public void TestOne()
        {

            WorkingNineToFive workingNineToFive = new(9f, 17f, 30f, 1.5f);
            float payCalculated = workingNineToFive.CalculatePay();
            Assert.AreEqual(240f, payCalculated);
            Console.WriteLine($"pay received is {payCalculated}");

        }

        [TestMethod]
        public void TestTwo()
        {

            WorkingNineToFive workingNineToFive = new(16f, 18f, 30f, 1.8f);
            float payCalculated = workingNineToFive.CalculatePay();
            Assert.AreEqual(84f, payCalculated);
            Console.WriteLine($"pay received is {payCalculated}");

        }

        [TestMethod]
        public void TestThree()
        {

            WorkingNineToFive workingNineToFive = new(13.25f, 15f, 30f, 1.5f);
            float payCalculated = workingNineToFive.CalculatePay();
            Assert.AreEqual(52.50f,payCalculated);
            Console.WriteLine($"pay received is {payCalculated}");


        }
    }
}
