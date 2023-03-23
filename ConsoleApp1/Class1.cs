using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Test
    {
        //public static void Main(string[] args)
        //{
        //    Class1 c = new(1, "IT", "name", (float)1.9);



        //    Console.WriteLine(c);
        //}
    }

     class Class1
    {
        public int id;
        public string name, department;
        public float grade;
        public Class1(int id, string department, string name, float grade)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.grade = grade;
        }

        public override string ToString()
        {
            return $"{name} with {id} from {department} having grade{grade}";
        }
    }
}
