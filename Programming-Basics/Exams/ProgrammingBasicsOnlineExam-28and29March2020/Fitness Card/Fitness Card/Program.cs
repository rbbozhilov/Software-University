using System;

namespace Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double oursum = double.Parse(Console.ReadLine());
            string pol = Console.ReadLine();
            int older = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double sum = 0;

            switch (pol)
            {

                case "m":
                    {

                        if (sport == "Gym")
                        {
                            sum = 42;
                        }
                        else if (sport == "Boxing")
                        {
                            sum = 41;
                        }
                        else if (sport == "Yoga")
                        {
                            sum = 45;
                        }
                        else if (sport == "Zumba")
                        {
                            sum = 34;
                        }
                        else if (sport == "Dances")
                        {
                            sum = 51;
                        }
                        else if (sport == "Pilates")
                        {
                            sum = 39;
                        }


                        if (older <= 19)
                        {

                            sum = sum - (sum * 0.2);

                        }


                        break;
                    }
                case "f":
                    {
                        if (sport == "Gym")
                        {
                            sum = 35;
                        }
                        else if (sport == "Boxing")
                        {
                            sum = 37;
                        }
                        else if (sport == "Yoga")
                        {
                            sum = 42;
                        }
                        else if (sport == "Zumba")
                        {
                            sum = 31;
                        }
                        else if (sport == "Dances")
                        {
                            sum = 53;
                        }
                        else if (sport == "Pilates")
                        {
                            sum = 37;
                        }


                        if (older <= 19)
                        {

                            sum = sum - (sum * 0.2);

                        }

                        break;

                    }
            }


            if (oursum > sum)
            {
                Console.WriteLine("You purchased a 1 month pass for {0}.", sport);
            }
            else
            {
                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (double)sum - oursum);
            }

        }
    }
}
