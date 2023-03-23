using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Red { }
}

namespace ConsoleApp1
{
    internal class TryCatch
    {
        public static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                CheckAge(age);
            }catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                
            }

            //catch(MyException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            
        }
        public static void CheckAge(int age) { 
            if(age < 18) {
                throw new MyException("You should be above 18 to cast vote");
             }
        }
        public class MyException:Exception
        {
            public MyException(string myMessage):base(myMessage) { 

            }
        }
    }
}
