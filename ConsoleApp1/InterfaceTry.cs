using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ITryInterface
    {
        public static int key;

        public void Method()
        {
            Console.WriteLine("Default defnition");
        }
    }


    public class DemoInterface :ITryInterface {
        public static int key;

        //public static void Main(string[] args)
        //{
        //    ITryInterface demoInterface = new DemoInterface();
        //    demoInterface.Method();
        //}
        
    }


    
}
