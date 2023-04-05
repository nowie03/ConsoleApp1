using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PopulateDb
    {
        public static  void populate()
        {

            using (StreamWriter writetext = new StreamWriter("C:\\Users\\hp\\Desktop\\demo\\filehandle.txt"))
            {
                Random random = new Random();   

                for (int i = 9; i < 20000; i++) { 
                    writetext.WriteLine($"Insert into EmployeeDetails values({i},'EmployeeName{random.Next(1,12)}','{((i%2)==0?"junior dev":"senior dev")}',{random.Next(100,19999)},{random.Next(20000,100000)});");
                }   
            }
        }

        public static void Main(string[] args)
        {
            populate();
        }




    }
}
