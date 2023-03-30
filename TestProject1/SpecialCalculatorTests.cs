using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class SpecialCalculatorTests
    {
        SpecialCalculator specialCalculator=new SpecialCalculator();

        [TestMethod]
        public void NormalModeAddition() {
            specialCalculator.SwitchMode(0);
            Assert.AreEqual(12, specialCalculator.Addition(6, 6));
        }

        [TestMethod]
        public void NormalModeSubtraction() {
            specialCalculator.SwitchMode(0);
            Assert.AreEqual(2, specialCalculator.Subtraction(6,4));
        }

        [TestMethod]
        public void OppositeModeAddition() {
            specialCalculator.SwitchMode(1);
            Assert.AreEqual(3, specialCalculator.Addition(9, 6));


        }
        [TestMethod]
        public void OppositeModeSubtraction()
        {
            specialCalculator.SwitchMode(1);
            Assert.AreEqual(8, specialCalculator.Subtraction(7, 1));


        }
    }
}
