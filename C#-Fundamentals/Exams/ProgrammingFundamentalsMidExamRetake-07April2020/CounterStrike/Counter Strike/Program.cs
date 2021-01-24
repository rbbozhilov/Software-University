using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string distance = string.Empty;
            int won = 0;

            while ((distance = Console.ReadLine()) != "End of battle")
            {


                int tDistance = int.Parse(distance);

                if (energy - tDistance >= 0)
                {
                    won++;
                    energy -= tDistance;
                    if (won % 3 == 0)
                    {
                        energy += won;
                    }
                }

                else
                {
                    Console.WriteLine("Not enough energy! Game ends with {0} won battles and {1} energy", won, energy);
                    Environment.Exit(0);
                }


            }


            Console.WriteLine("Won battles: {0}. Energy left: {1}", won, energy);
        }
    }
}
