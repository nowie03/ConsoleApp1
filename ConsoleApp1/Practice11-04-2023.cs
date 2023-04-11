using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Practice11_04_2023
    {
        public bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in input)
            {
                if(c == '(')
                {
                    stack.Push(c);
                }
                else if(c == ')')
                {
                    if(stack.Count ==0) { 
                        return false;
                    }
                    char charAtTop = stack.Peek();
                    if (charAtTop == ')')
                        return false;
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            return false;
        }

        public void GenerateCombination(int n,string input, List<string>output) 
        {
            if (input.Length > 2*3)
                return ;
            
            if(IsBalanced(input) && input.Length == 2*n)
            {
                output.Add(input);
                return;
            }

            GenerateCombination(n, input + '(', output);
            GenerateCombination(n, input + ')', output);


        }
    }
}
