using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

public class PracticeQns23
{
    public static void Main(string[] args)
    {
        //List<int>  a = new List<int>();
        //a.Add(1);
        //a.Add(2);
        //a.Add(3);
        //a.Add(4);
        //a.Add(1);
        //a.Add(6);

        //Console.WriteLine(TotalNumberOfDupilcates(a));


        //List<int> odd, even;
        //Seperate(out odd, out even,20);

        //foreach(int i in odd) Console.Write(i+" ");
        //Console.WriteLine();
        //foreach (int i in even) Console.Write(i+" ");
        

        List<int>a = new List<int>() { 9,1,3,6};
        List<int> b= new List<int>() { 11, 2, 13, 26 };
        foreach (int i in MergeSorted(a,b)) { 
            Console.WriteLine(i);
        }

    }



    public static void Seperate(out List<int>odd,out List<int>even,int cap)
    {
        odd = new List<int>();
        even = new List<int>();
        for (int i=1; i <= cap; i++){
            if((int)(i&1)==1 )odd.Add(i);
            else even.Add(i);
        }
    }

    public static List<int> MergeSorted(List<int> a, List<int> b)
    {
        a.Sort((x,y) => x < y?-1:1);
        b.Sort((x, y) => x < y ? -1 : 1);

        List<int>res=new List<int>(a.Count+b.Count);

        int aIndex = 0, bIndex = 0,resIndex=0;

        while (aIndex<a.Count && bIndex<b.Count)
        {
            res[resIndex++] = (a[aIndex] < b[bIndex]) ? a[aIndex++] : b[bIndex++];

            
        }

        while (aIndex < a.Count) res[resIndex++] = a[aIndex++];
        while (bIndex < b.Count) res[resIndex++] = b[bIndex++];



        return res;

    }

    public static int TotalNumberOfDupilcates<T>(List<T>arr)
    {
     Dictionary<T,int> dict = new Dictionary<T,int>();  
        foreach (T item in arr)
        {
            if (dict.ContainsKey(item) ) dict[item] += 1;
            else dict.Add(item,1); 
        }
        int dups = 0;
        foreach (int nos in dict.Values) {
            dups+=(nos > 1) ? 1 : 0;
        }
        return dups;
    }
}
