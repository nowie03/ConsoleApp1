using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LicensePlateReArrange
    {
        public string ReverseString(string input)
        {
            //utility function for reversing a string
            string reversedString = "";
            for(int index=input.Length-1;index>=0;index--)
                reversedString += input[index];
            return reversedString;
        }

        public string LicensePlate(string input,int length)
        {
            //formatted string will be our return string
            //tempLength keeps track of count of characters added in return string bfore a hyphen
            string formattedString = "";
            int tempLength = 0;

            //traverse input string right to left and only add it to the formatted string if you have
            // a character not a hyphen , reset temp length when a hyphen is added
            for(int index = input.Length - 1; index >= 0; index--)
            {
                if(tempLength == length)
                {
                    formattedString += "-";
                    tempLength = 0;
                }
                if (!input[index].Equals('-'))
                {
                    formattedString += input[index];
                    tempLength++;
                }
                
            }

            //reverses and returns the uppercase string
            return ReverseString(formattedString.ToUpper());
        }
    }
}
