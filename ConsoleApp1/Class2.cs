using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class TestMain {
        public static void Main(string[] args)
        {
            Class2 c = new();
            //Console.WriteLine(c.ToString());
        }
    }
     class Class2
    {
       
        public Class2() {
            Console.WriteLine("Constructing");
        }
         ~Class2() {
            Console.WriteLine("destructing");
        }

    }
}
