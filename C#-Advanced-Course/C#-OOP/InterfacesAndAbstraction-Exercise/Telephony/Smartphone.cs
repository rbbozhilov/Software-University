using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Contracts;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {

      
   
        public void Browse(string browser)
        {

            bool validation = browser.Any(char.IsDigit);
            
            
            if (!validation)
            {
                Console.WriteLine("Browsing: {0}!", browser);
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }


        }

        public void Call(string phone)
        {

            bool validation = phone.Any(char.IsLetter);

           

            if (!validation)
            {

                Console.WriteLine("Calling... {0}", phone);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

        }
    }
}
