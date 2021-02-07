using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> regularReservation = new HashSet<string>();
            HashSet<string> vipReservation = new HashSet<string>();
            bool flagParty = false;
            string command = string.Empty;

            while((command=Console.ReadLine()) !="END")
            {

                if(command=="PARTY")
                {
                    flagParty = true;
                    continue;
                }

                if(flagParty)
                {

                    

                    if(vipReservation.Contains(command))
                    {
                        vipReservation.Remove(command);
                    }
                    else if(regularReservation.Contains(command))
                    {
                        regularReservation.Remove(command);
                    }

                }
                else
                {

                    if(command.Length==8)
                    {


                        if(Char.IsDigit(command[0]))
                        {
                            vipReservation.Add(command);
                        }

                        else
                        {
                            regularReservation.Add(command);
                        }


                    }

                }


            }


            Console.WriteLine(regularReservation.Count+vipReservation.Count);

            foreach(var items in vipReservation)
            {
                Console.WriteLine(items);
            }

            foreach(var items in regularReservation)
            {
                Console.WriteLine(items);
            }

        }
    }
}
