using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;

public class practiceQns2403
{

    public static void RemoveOk() {
        string input = Console.ReadLine();
        if (input.Length < 2) return;
        List<int>removedIndexes = new List<int>();
        int currentIndex = 0;
        Stack<int>st =new Stack<int>();
        while(currentIndex<input.Length)
        {
            if (input[currentIndex]=='o' || input[currentIndex] == 'k')
                st.Push(currentIndex);  

            if (st.Count >=2)
            {
                int c1 = st.Pop();
                int c2 = st.Pop();
                string temp = "" + input[c2] + input[c1];
                if (temp.Equals("ok"))
                {
                   
                    removedIndexes.Add(c1);
                    removedIndexes.Add(c2);
                }
                else
                {
                    st.Push(c2);
                    st.Push(c1);
                }
            }
            currentIndex++;
        }
        for(int i = 0; i < input.Length; i++)
        {
            if(!removedIndexes.Contains(i))
            {
                Console.Write(input[i]);
            }
        }
    }

    public static void AddFrontAndBack()
    {
        string input = Console.ReadLine();

        if (input.Length < 1)
            return;

        string newString = $"{input[input.Length-1]}{input}{input[input.Length-1]}";

        Console.WriteLine( newString);

    }
	public static void StringManipulation()
	{

        string input = Console.ReadLine();

        string newString = "";

        newString += input[input.Length - 1];

        if (input.Length < 1) return ;    

        for (int i = 1; i < input.Length - 1; i++) newString += input[i];

        newString += input[0];

        Console.WriteLine(newString);
    }
	
}
