using System;

namespace ConsoleApp1
{
    public class RemovingAllOccurencesOfOk
    {
        public static string RemoveOk(string input)
        {
            //default check for strings less than 2
            if (input.Length < 2) return input;

            /*  -removedIndexes keeps track of all the indexes that
             *      corresponds to either 'o' or 'k' in the input string 
                -currentIndex keeps track of currentIndex added to the stack
                -st is a stack ds keeps record of all indexes of the input string

            */
            List<int> removedIndexes = new List<int>();
            int currentIndex = 0;
            Stack<int> st = new Stack<int>();

            while (currentIndex < input.Length)
            {
                //push the index to the stack only if they corresponds
                //to o or k in the input string
                if (input[currentIndex] == 'o' || input[currentIndex] == 'k')
                    st.Push(currentIndex);

                if (st.Count >= 2)
                {
                    //when stack size goes above we might have a
                    //probable ok in the stack and we look to remove it
                    int c1 = st.Pop();
                    int c2 = st.Pop();
                    string temp = "" + input[c2] + input[c1];
                    if (temp.Equals("ok"))
                    {
                        //if we do have a ok then we flag those indexes to remove
                        removedIndexes.Add(c1);
                        removedIndexes.Add(c2);
                    }
                    else
                    {
                        /*this step is crucial if we dont add this step then we can miss a 
                         * probable index which is either a o or k
                         * that can
                         * make a ok in future
                         */
                        st.Push(c2);
                        st.Push(c1);
                    }
                }
                currentIndex++;
            }

            //add all the indexes except the ones flagged
            string answer = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (!removedIndexes.Contains(i))
                {
                    answer += input[i];
                }
            }
            return answer;
        }

        //public static void Main(string[] args)
        //{
        //    string input = Console.ReadLine();
        //    Console.WriteLine(RemoveOk(input));

        //}

    }
}
