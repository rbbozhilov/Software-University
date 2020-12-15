using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            switch (season)
            {
                case "Summer":
                    {
                        if (budjet <= 1000)
                        {

                            budjet = budjet * 0.65;

                            Console.WriteLine("Alaska - Camp - {0:F2}", budjet);

                        }
                        else if (budjet > 1000 && budjet <= 3000)
                        {
                            budjet = budjet * 0.8;
                            Console.WriteLine("Alaska - Hut - {0:F2}", budjet);
                        }
                        else if (budjet > 3000)
                        {
                            budjet = budjet * 0.9;
                            Console.WriteLine("Alaska - Hotel - {0:F2}", budjet);
                        }

                        break;
                    }

                case "Winter":
                    {

                        if (budjet <= 1000)
                        {

                            budjet = budjet * 0.45;

                            Console.WriteLine("Morocco - Camp - {0:F2}", budjet);

                        }
                        else if (budjet > 1000 && budjet <= 3000)
                        {
                            budjet = budjet * 0.6;
                            Console.WriteLine("Morocco - Hut - {0:F2}", budjet);
                        }
                        else if (budjet > 3000)
                        {
                            budjet = budjet * 0.9;
                            Console.WriteLine("Morocco - Hotel - {0:F2}", budjet);
                        }


                        break;
                    }

            }
        }
    }
}
