using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AsyncPracticeQn
    {
        public async Task PickupChiefGuest()
        {
            Console.WriteLine("set out to pickup Chief Guest");
            await Task.Delay(10000);
            Console.WriteLine("Chief Guest Arrived");

        }

        public async Task ReviewChiefGuestSpeech()
        {
            Console.WriteLine("Reviewing Chief Guest speech");
            await Task.Delay(1000);
            Console.WriteLine("chief guest speech checked");

        }

        public async Task SecurityCheck()
        {
            Console.WriteLine("Reviewing Chief Guest security");
            await Task.Delay(2000);
            Console.WriteLine("chief guest security checked");
        }
        public async Task TransportRawMaterials() {
            Console.WriteLine("Transporting Raw materials");
            await Task.Delay(3000);
            Console.WriteLine("Raw materials transported");

        }

        public async Task Cook()
        {
            Console.WriteLine("Food preparation started");
            await Task.Delay(3000);
            Console.WriteLine("food preparation ended");
        }

        public async Task DecorateStage()
        {
            Console.WriteLine("stage decoration started");
           await Task.Delay(000);
            Console.WriteLine("stage decoration ended");
        }

        public async Task BringPrizes()
        {
            Console.WriteLine("transporting prizes");
           await Task.Delay(3000);
            Console.WriteLine("prizes transported");

        }
        public async Task ChiefGuestSpeech()
        {
            Console.WriteLine(" Chief Guest speech started");
            await Task.Delay(4000);
            Console.WriteLine("chief guest speech ended");
        }

        public async Task PrizeDistribution()
        {
            Console.WriteLine(" prize distribution started");
            await Task.Delay(2000);
            Console.WriteLine("prize distribution  ended");

        }

        public async Task FoodServe()
        {
            Console.WriteLine(" food serve started");
            await Task.Delay(4000);
            Console.WriteLine("food serving ended");
        }

        public async Task StartFunction(AsyncPracticeQn asyncPracticeQn)
        {
            //transporting raw materials and functions
            await Task.WhenAll(asyncPracticeQn.TransportRawMaterials(),
            asyncPracticeQn.BringPrizes());

            //Other pre function preparations
            await Task.WhenAll(asyncPracticeQn.Cook(),
            asyncPracticeQn.PickupChiefGuest(),
            asyncPracticeQn.ReviewChiefGuestSpeech(),
            asyncPracticeQn.SecurityCheck(),
            asyncPracticeQn.DecorateStage());

            //function happenings
            await asyncPracticeQn.ChiefGuestSpeech();
            await asyncPracticeQn.PrizeDistribution();
            await asyncPracticeQn.FoodServe();
        }

        public static async Task Main(string[]args)
        {

            AsyncPracticeQn asyncPracticeQn = new();
            await asyncPracticeQn.StartFunction(asyncPracticeQn);
            
            Console.ReadKey();

            


        }


    }
}
