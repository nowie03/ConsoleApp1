using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp1
{

    public class TestMain {
        //public static void Main(string[] args)
        //{
        //    Desturctor c = new();
        //    //Console.WriteLine(c.ToString());
        //}
    }
     class Desturctor
    {
        
       
        public Desturctor() {
            Console.WriteLine("Constructing");
        }
         ~Desturctor() {
            Console.WriteLine("destructing");
        }

    }
}
