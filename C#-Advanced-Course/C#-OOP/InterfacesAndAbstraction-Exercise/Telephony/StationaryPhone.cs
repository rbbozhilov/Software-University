using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Contracts;
using System.Linq;

namespace Telephony
{
   public class StationaryPhone : ICall
    {

      

   
        public void Call(string phone)
        {
            bool validation = phone.Any(char.IsLetter);

            if (!validation)
            {

                Console.WriteLine("Dialing... {0}", phone);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            
        }
    }
}
