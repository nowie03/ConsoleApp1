using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LambdaExpressionsTry
    {
        delegate T GenericDelegate<T>(T a ,T b);
        public static void Main(string[] args)
        {
            GenericDelegate<int> lambaAdd = (num1, num2) => num1 + num2;
            Console.WriteLine(lambaAdd(2, 3));

            //lambda multicast
            var lambdaWODelegate = (int num1,int num2) => num1 + num2;

            lambdaWODelegate += (int num1, int num2) => num1 - num2;
            Console.WriteLine(lambdaWODelegate(2, 3));




            foreach (var i in lambdaWODelegate.GetInvocationList())
            {
                Console.WriteLine(i.Method);
                Console.WriteLine(i.DynamicInvoke(3, 4));
            }

            //lambda use cases

            List<int> someList = new() { 19, 5, 3, 2, 35, 10, 34, 60 };
            var square = (int num1) => num1 * num1;

            foreach (int i in someList)
               Console.WriteLine(square(i));

            Console.WriteLine(someList.Aggregate((int num1, int num2) => num1 + num2));

            Console.WriteLine(someList.All((int a) => a > 10));

            //add all elements divisble by 5 in new list
            List<int>divisbleBy5=someList.FindAll(a => a %5==0);

            foreach (int i in divisbleBy5)
                Console.Write(i + " ");
   
        }

       
    }
}
