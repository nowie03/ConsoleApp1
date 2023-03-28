using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DelegatesTry
    {
        public delegate int DelegateForSum(int a ,int b);
        public delegate void DelegateForGeneric<T> (T a,T  b);
        public static void Main(string[] args)
        {
            DelegateForSum delegateForSum = Sum;
            delegateForSum += Diff;

            DelegateForGeneric<int> dt = GenericTryFun1;
            DelegateForGeneric<string> dt1 = GenericTryFun2;






            foreach (DelegateForSum d in delegateForSum.GetInvocationList()) {
                Console.WriteLine(d.Invoke(3,4));
            }


            
        }



        public static void delegateInvoking(string name,int a,int b, DelegateForSum func)
        {
            //call back
            Console.WriteLine(name+" "+ func(a,b));
        }

        
        private static int Diff(int a,int b) {
            return a - b;
        }
        private static int Sum(int a ,int b)
        {
            return a + b;
        }

       private static void GenericTryFun1(int a,int b) { Console.WriteLine("a/b"); }

        private static void GenericTryFun2(string a,string b) { Console.WriteLine(a+" "+b);}
    }
}
