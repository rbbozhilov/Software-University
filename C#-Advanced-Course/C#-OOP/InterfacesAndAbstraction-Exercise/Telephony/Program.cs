using System;
using Telephony.Contracts;

namespace Telephony
{
   public class Program
    {
        static void Main(string[] args)
        {

            string[] phoneNumbers = Console.ReadLine().Split(" ");

            for(int i=0;i<phoneNumbers.Length;i++)
            {

                if(phoneNumbers[i].Length==7)
                {
                    ICall caller = new StationaryPhone();
                    caller.Call(phoneNumbers[i]);
                }

                else
                {
                    ICall caller = new Smartphone();
                    caller.Call(phoneNumbers[i]);
                }

            }

            string[] browsers = Console.ReadLine().Split(" ");

            for(int i=0;i<browsers.Length;i++)
            {

                IBrowse browse = new Smartphone();
                browse.Browse(browsers[i]);

            }


        }
    }
}
