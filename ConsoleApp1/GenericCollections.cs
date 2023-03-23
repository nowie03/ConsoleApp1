using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

public class GenericColledctions
{
	public static void Main(string[] args)
	{
		var myList=new List<string>();
		myList.Add("A");
        myList.Add("B");
		myList.Add("C");
		myList.Add("D");

		myList.Sort((a,b)=> a.Length.CompareTo(b.Length));

		foreach (var item in myList)
		{
			Console.WriteLine(item);
		}


		var mySortedList = new SortedList<string, int>();
        mySortedList.Add("A", 1);
        mySortedList.Add("a", 2);

		foreach (var item in mySortedList)
		{
			Console.WriteLine(item.Key + " " + item.Value);
		}

		var myDictionary =new Dictionary<string, int>();
		myDictionary.Add("A", 1);
		myDictionary.Add("B", 2);
		myDictionary.Add("C", 3);

        foreach (var item in myDictionary)
        {
            Console.writeline(item.key + " " + item.value);
        }



        var mySortedDictionary =new SortedDictionary<string, int>();
		mySortedDictionary.Add("D", 4);
		mySortedDictionary.Add("d", 1);


		foreach (var item in mySortedDictionary.OrderBy(x => x.Value))
		{
			Console.WriteLine(item.Key + " " + item.Value);
		}


		

		Stack<int> st = new();
		st.Push(1);	
		st.Push(2);

		while (st.Count != 0)
		{
			int a;
			st.TryPeek(out a);
			Console.WriteLine(a);
			st.Pop();
		}


		

    }
}
