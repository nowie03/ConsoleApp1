using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class LicensePlateTest
    {
        [TestMethod]
        public void TestCaseOne()
        {
            LicensePlateReArrange licensePlateReArrange = new();
            string actualResult= licensePlateReArrange.LicensePlate("5F3Z-2e-9-w",4);
            string expected = "5F3Z-2E9W";
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void TestCaseTwo()
        {
            LicensePlateReArrange licensePlateReArrange = new();
            string actualResult = licensePlateReArrange.LicensePlate("2-5g-3-J", 2);
            string expected = "2-5G-3J";
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void TestCaseThree()
        {
            LicensePlateReArrange licensePlateReArrange = new();
            string actualResult = licensePlateReArrange.LicensePlate("2-4A0r7-4k", 3);
            string expected = "24-A0R-74K";
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void TestCaseFour()
        {
            LicensePlateReArrange licensePlateReArrange = new();
            string actualResult = licensePlateReArrange.LicensePlate("nlj-206-fv", 3);
            string expected = "NL-J20-6FV";
            Assert.AreEqual(expected, actualResult);
        }

    }
}
