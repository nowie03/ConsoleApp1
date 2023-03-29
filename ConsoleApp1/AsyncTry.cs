using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    internal class AsyncTry {

        public static string Path = "C:\\Users\\hp\\Documents\\readFile.txt";
    public static async Task<int> Method1()
    {
        Console.WriteLine("method 1 started");
         await Task.Delay(3000);
        Console.WriteLine("method 1 ended");
         return 1;
    }

        public static async Task<int> Method2()
        {
            Console.WriteLine("method 2 started");
            await Task.Delay(5000);
            Console.WriteLine("method 2 ended");
            return 2;
        }

        public static async Task<int> Method3()
        {
            Console.WriteLine("method 3 started");
            await Task.Delay(5000);
            Console.WriteLine("method 3 ended");
            return 1;
        }

        public static async Task<FileStream?> FileOpenMethod()
        {
            FileStream file= null;
            await Task.Run(() =>
            {
                file = new(Path, FileMode.OpenOrCreate);
            });

            return file;

        }

        public static async void FileWriteMethod(FileStream file,string message)
        {
            using (StreamWriter st = new StreamWriter(file))
            {
                st.Write(message);

            }

        }

        public static async Task<string> FileReadMethod()
        {
            string message = null;
            FileStream file = new FileStream(Path,FileMode.Open,FileAccess.Read);
            using (StreamReader st = new StreamReader(file))
            {
                message=st.ReadToEnd();

            }

            return message;

        }

        public static async Task  Main()
        {

            var progress =   Task.WhenAll(Method1(), Method2());

            while (!progress.IsCompleted)
            {
                Console.WriteLine(progress.Status);
                Thread.Sleep(1000);
            }

           foreach (var result in  progress.Result){
                Console.WriteLine(result);
            }


            var progressAny = Task.WhenAny(Method1(), Method2());

            while (!progress.IsCompleted)
            {
                Console.WriteLine(progress.Status);
                Thread.Sleep(1000);
            }

            foreach (var result in progress.Result)
            {
                Console.WriteLine(result);
            }






        }
    
    }
}
