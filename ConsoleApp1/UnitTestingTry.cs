using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UnitTestingTry
    {
        public static int Method1(int a, int b) {
            return a + b;
        }

        public static int Method2()
        {
            throw new NotImplementedException();
        }
    }
}
