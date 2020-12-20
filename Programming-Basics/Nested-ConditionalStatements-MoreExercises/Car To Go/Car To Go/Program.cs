using System;

namespace Car_To_Go
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

                        if (budjet <= 100)
                        {
                            Console.WriteLine("Economy class");

                            budjet = (budjet * 0.35);
                            Console.WriteLine("Cabrio - {0:F2}", budjet);


                        }

                        else if (budjet > 100 && budjet <= 500)
                        {
                            Console.WriteLine("Compact class");

                            budjet = (budjet * 0.45);

                            Console.WriteLine("Cabrio - {0:F2}", budjet);

                        }
                        else if (budjet > 500)
                        {
                            Console.WriteLine("Luxury class");
                            budjet = (budjet * 0.9);

                            Console.WriteLine("Jeep - {0:F2}", budjet);


                        }

                        break;
                    }

                case "Winter":
                    {
                        if (budjet <= 100)
                        {
                            Console.WriteLine("Economy class");

                            budjet = (budjet * 0.65);
                            Console.WriteLine("Jeep - {0:F2}", budjet);


                        }

                        else if (budjet > 100 && budjet <= 500)
                        {
                            Console.WriteLine("Compact class");

                            budjet = (budjet * 0.8);

                            Console.WriteLine("Jeep - {0:F2}", budjet);

                        }
                        else if (budjet > 500)
                        {
                            Console.WriteLine("Luxury class");
                            budjet = (budjet * 0.9);

                            Console.WriteLine("Jeep - {0:F2}", budjet);


                        }


                        break;
                    }

            }
        }
    }
}
