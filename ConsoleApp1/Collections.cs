using System;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
	public class MyCollections<T>
	{
		//genric class
		T value;
		public MyCollections(T val)
		{
			this.value = val;
			Console.WriteLine($"My  generic collection and has type {typeof(T)}");
		}
	}


	public class CollectionsMain{

		//public static void Main(string[] args)
		//{
		//	MyCollections<int> mt = new MyCollections<int>(2);
		//	GenricMethod("string");
		//}

		public static void GenricMethod<T>(T val)
		{
			//genric method
			Console.WriteLine(val);
		}
	}

}


