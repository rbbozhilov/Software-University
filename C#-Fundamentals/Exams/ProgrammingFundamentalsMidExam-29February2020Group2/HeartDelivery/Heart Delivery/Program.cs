using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            string command = string.Empty;
            int currentIndex = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] tokens = command.Split();
                int length = int.Parse(tokens[1]);


                for (int i = 0; i < length; i++)
                {
                    currentIndex++;

                    if (currentIndex == numbers.Count)
                    {
                        currentIndex = 0;
                        break;
                    }

                }

                if (numbers[currentIndex] > 0)
                {
                    numbers[currentIndex] -= 2;

                    if (numbers[currentIndex] <= 0)
                    {
                        Console.WriteLine("Place {0} has Valentine's day.", currentIndex);
                    }
                }

                else
                {
                    Console.WriteLine("Place {0} already had Valentine's day.", currentIndex);
                }

            }

            Console.WriteLine("Cupid's last position was {0}.", currentIndex);

            bool isSuccess = true;
            int count = 0;

            foreach (var items in numbers)
            {
                if (items != 0)
                {
                    isSuccess = false;
                    count++;
                }
            }

            if (isSuccess)
            {
                Console.WriteLine("Mission was successful.");
            }

            else
            {
                Console.WriteLine("Cupid has failed {0} places.", count);
            }
        }
    }
}
