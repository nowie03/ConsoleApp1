using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class LuckyNumberPredictor
    {

        public static long GetYourLuckyNumber(int day,int month,int year)
        {
            return NumberPredictor.PredictLuckyNumber(day,month,year);
        }

        private class NumberPredictor {

            private static long[] fibonnaciNumbers=new long[40];

            private static void generateFibonnaciNumbers()
            {
             
                fibonnaciNumbers[0] = 1;
                fibonnaciNumbers[1] = 2;
                for(int i= 2; i < fibonnaciNumbers.Length; i++)
                {
                    fibonnaciNumbers[i] = fibonnaciNumbers[i - 1] + fibonnaciNumbers[i-2];
                }
            }

            public static long PredictLuckyNumber(int day,int month,int year)
            {
                generateFibonnaciNumbers();

                long roundOff=day * 1000000+ month *10000 + year;

                long closestFibonnaciNumber = fibonnaciNumbers[0];
                for(int i = 0; i < fibonnaciNumbers.Length; i++)
                {
                    if (fibonnaciNumbers[i] > roundOff)
                    {
                        closestFibonnaciNumber = fibonnaciNumbers[i];
                        break;
                    }
                }
                return closestFibonnaciNumber;
            }

            public static long PredictUnluckyNumber(int day,int month,int year)
            {
                throw new Exception("Not yet Implemented");
            }

        }
    }
}
