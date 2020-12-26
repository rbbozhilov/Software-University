using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int heightWall = int.Parse(Console.ReadLine());
            int weightWall = int.Parse(Console.ReadLine());
            int percentWall = int.Parse(Console.ReadLine());


            double total = heightWall * weightWall * 4;
            double painedWalls = (double)percentWall / 100.0;
            painedWalls = total - (total * painedWalls);

            painedWalls = Math.Ceiling(painedWalls);

            string text = string.Empty;
            bool flag = false;
            while ((text = Console.ReadLine()) != "Tired!")
            {


                int boia = int.Parse(text);

                painedWalls -= boia;

                if (painedWalls < 0)
                {
                    Console.WriteLine("All walls are painted and you have {0} l paint left!", Math.Abs(painedWalls));
                    Environment.Exit(0);
                }
                else if (painedWalls == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");

                    Environment.Exit(0);
                }


            }

            if (flag == false)
            {
                Console.WriteLine("{0} quadratic m left.", painedWalls);
            }

        }
    }
}
