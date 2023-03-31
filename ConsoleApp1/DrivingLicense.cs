using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DrivingLicense
    {
        public int License(string myName,int noOfAgents,string otherNames)
        {
            otherNames+= " "+myName;
            //sorting names to get the current position of myName in alphabetical order
            List<string> memberList = new List<string>(otherNames.Split(" "));
            memberList.Sort();
            
            //current postition how many people preceds me in the alphabetical order
            int currentPosition =memberList.IndexOf(myName);

            //if there is x agents they can concurrently handle x names
            //therefore time taken to process people preceding me will be
            int timeTakesForYou = (currentPosition/noOfAgents)* 20;

            //additionally 20 min for my process
            timeTakesForYou += 20;
                
            return timeTakesForYou;


        }
    }
}
