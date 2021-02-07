using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {

            string commands = string.Empty;
            HashSet<string> carNumbers = new HashSet<string>();

            while((commands=Console.ReadLine()) !="END")
            {

                string[] tokens = commands.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];
                string currentNumber = tokens[1];

                if(currentCommand=="IN")
                {
                    carNumbers.Add(currentNumber);
                }
                else if(currentCommand=="OUT")
                {
                    if(carNumbers.Contains(currentNumber))
                    {
                        carNumbers.Remove(currentNumber);
                    }
                }


            }

            if (carNumbers.Count > 0)
            {
                foreach (var items in carNumbers)
                {
                    Console.WriteLine(items);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
