using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccessSpecifiersTry
    {
        private static string privateVariable = "private string";
        public static  string publicVariable = "public string";
        protected static string protectedVariable = "protected string";
        internal static string internalVariable = "internal string";
    }

    public class DerviedClass : AccessSpecifiersTry
    {
        //public static void main(string[] args)
        //{
        //    //console.writeline(privateVariable);
        //    Console.WriteLine(publicVariable);
        //    Console.WriteLine(protectedVariable);
        //    Console.WriteLine(internalVariable);


        //}
    }

    public class NonDerivedClass
    {
        //public static void Main(string[] args)
        //{
            
        //    Console.WriteLine(DerviedClass.privateVariable);
        //    Console.WriteLine(DerviedClass.protectedVariable);
        //    Console.WriteLine(DerviedClass.internalVariable);
        //    Console.WriteLine(DerviedClass.publicVariable);


        //}
    }
}
