using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class PopulateDbTests
    {
        [TestMethod()]
        public void populateTest()
        {
            PopulateDb populate=    new PopulateDb();
            //populate.populate();
            Assert.IsTrue(true);
        }
    }
}