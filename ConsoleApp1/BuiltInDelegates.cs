using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CustomType {
       public int num = 10;

    }
    internal class BuiltInDelegates
    {
        
        //public static void Main(string[] args) { 
        //    //built in delegates
        //    //Action is used for functions with no return type
        //    Action<string> sayHelloDelegate = (message)=>Console.WriteLine(message);
        //    //func is used for functions with a return type
        //    Func<int, int, string> returnNumberDelegate=(num1, num2) => ""+num1 + num2;
        //    //predicates returns bool only and takes one parameter
        //    Predicate<string> predicateCheck = (name) => name.StartsWith("s");

        //    sayHelloDelegate.Invoke("message pass");

        //    Console.WriteLine(returnNumberDelegate(1,2));

        //    //return custom objects from lambdas
        //    Func<CustomType> customTypeReturn = () =>
        //    {
        //        CustomType c1 = new();
        //        return c1;
        //    };

        //    Console.WriteLine(customTypeReturn().num);

        //    //returnig collections with lambdas

        //    Func<List<int>, bool> collectionsFun = (myList) =>
        //    {
        //        return myList.Count == 1;
        //    };

        //    Console.WriteLine(collectionsFun(new List<int>() { 1, 2, 3 }));

        //    List<int> list = new List<int>() { 2,3,4,5};
        //    Console.WriteLine(list.All((a)=>a>2));

              
        //}
    }
}
