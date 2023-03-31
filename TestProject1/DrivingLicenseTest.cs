using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class DrivingLicenseTest
    {
        [TestMethod]
        public void TestCaseOne()
        {
            DrivingLicense drivingLicense = new DrivingLicense();
            int actual= drivingLicense.License("Eric", 2, "Adam Caroline Rebecca Frank");
            int expected = 40;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCaseTwo()
        {
            DrivingLicense drivingLicense = new DrivingLicense();
            int actual = drivingLicense.License("Zebediah", 1, "Bob Jim Becky Pat");
            int expected = 100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCaseThree()
        {
            DrivingLicense drivingLicense = new DrivingLicense();
            int actual = drivingLicense.License("Aaron", 3, "Jane Max Olivia Sam");
            int expected = 20;

            Assert.AreEqual(expected, actual);
        }
    }
}
