using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> potatoPlayers = new Queue<string>(names);

            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            while (potatoPlayers.Count > 1)
            {
                counter++;

                if (counter == number)
                {
                    Console.WriteLine("Removed {0}", potatoPlayers.Dequeue());
                    counter = 0;
                    continue;
                }

                potatoPlayers.Enqueue(potatoPlayers.Dequeue());


            }

            Console.WriteLine("Last is {0}", potatoPlayers.Dequeue());
        }
    }
}
