using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SpecialCalculator
    {
        private int Mode=0;
        //0 stands for normal Mode
        //1 stands for opposite Mode

        public string SwitchMode(int mode) {
            Mode = mode;    

            string modeToBeReturned = (Mode == 0) ? "Normal" : "Opposite";

            return $"The calculator is in {modeToBeReturned}";
            
        }
        public int Addition(int number1,int number2)
        {
            if (Mode == 0)
                return number1 + number2;

            return number1 - number2;
        }

        public int Addition(int number1, int number2,int number3)
        {
            if (Mode == 0)
                return number1 + number2 + number3;

            return number3-number2 - number1;
        }
        public int Subtraction(int number1,int number2)
        {
            if (Mode == 0)
                return number1 - number2;

            return number2 + number1;
        }

        public int Subtraction(int number1, int number2,int number3)
        {
            if (Mode == 0)
                return number3 - number2-number1;

            return number2 + number1+number3;
        }
    }
}
