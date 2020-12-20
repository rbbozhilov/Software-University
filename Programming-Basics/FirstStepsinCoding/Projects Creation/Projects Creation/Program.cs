using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int broi = int.Parse(Console.ReadLine());

            if (broi >= 0 && broi <= 100)
            {

                Console.WriteLine("The architect " + name + " will need " + broi * 3 + " hours to complete " + broi + " project/s.");

            }
        }
    }
}
