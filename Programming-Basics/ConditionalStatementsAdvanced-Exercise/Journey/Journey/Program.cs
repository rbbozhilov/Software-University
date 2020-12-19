using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();

            double sum = 0;

            switch (sezon)
            {

                case "summer":
                    {
                        if (budjet <= 100)
                        {

                            sum = budjet * 0.3;

                            Console.WriteLine("Somewhere in Bulgaria\nCamp - {0:F2}", sum);

                        }
                        else if (budjet > 100 && budjet <= 1000)
                        {
                            sum = budjet * 0.4;
                            Console.WriteLine("Somewhere in Balkans\nCamp - {0:F2}", sum);
                        }
                        else if (budjet > 1000)
                        {
                            sum = (budjet * 0.9);
                            Console.WriteLine("Somewhere in Europe\nHotel - {0:F2}", sum);
                        }


                        break;
                    }


                case "winter":
                    {
                        if (budjet <= 100)
                        {

                            sum = (budjet * 0.7);

                            Console.WriteLine("Somewhere in Bulgaria\nHotel - {0:F2}", sum);

                        }
                        else if (budjet > 100 && budjet <= 1000)
                        {
                            sum = (budjet * 0.8);
                            Console.WriteLine("Somewhere in Balkans\nHotel - {0:F2}", sum);
                        }
                        else if (budjet > 1000)
                        {
                            sum = (budjet * 0.9);
                            Console.WriteLine("Somewhere in Europe\nHotel - {0:F2}", sum);
                        }


                        break;
                    }

            }
        }
    }
}
