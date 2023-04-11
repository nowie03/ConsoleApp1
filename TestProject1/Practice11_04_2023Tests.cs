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
    public class Practice11_04_2023Tests
    {
        [TestMethod()]
        public void GenerateCombinationTest_n_3()
        {
            Practice11_04_2023 practice11_04_2023 = new Practice11_04_2023();
            List<string> actual = new List<string>();
            List<string> expected = new List<string>() { "((()))", "(()())", "(())()", "()(())", "()()()" };
            practice11_04_2023.GenerateCombination(3, "", actual);
            
            for(int index=0;index<actual.Count;index++)
            {
                Assert.AreEqual(expected[index], actual[index]);
            }
           
        }

        [TestMethod()]
        public void GenerateCombinationTest_n_1()
        {
            Practice11_04_2023 practice11_04_2023 = new Practice11_04_2023();
            List<string> actual = new List<string>();
            List<string> expected = new List<string>() { "()" };
            practice11_04_2023.GenerateCombination(1, "", actual);

            for (int index = 0; index < actual.Count; index++)
            {
                Assert.AreEqual(expected[index], actual[index]);
            }

        }
    }
}