using System;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometri = double.Parse(Console.ReadLine());
            switch (season)
            {

                case "Spring":
                    {
                        double zaplata = 0;

                        if (kilometri <= 5000)
                        {
                            zaplata = kilometri * 0.75;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }
                        else if (kilometri > 5000 && kilometri <= 10000)
                        {
                            zaplata = kilometri * 0.95;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }
                        else if (kilometri > 10000 && kilometri <= 20000)
                        {
                            zaplata = kilometri * 1.45;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }


                        break;
                    }


                case "Summer":
                    {


                        double zaplata = 0;

                        if (kilometri <= 5000)
                        {
                            zaplata = kilometri * 0.9;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }
                        else if (kilometri > 5000 && kilometri <= 10000)
                        {
                            zaplata = kilometri * 1.1;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }
                        else if (kilometri > 10000 && kilometri <= 20000)
                        {
                            zaplata = kilometri * 1.45;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }



                        break;
                    }


                case "Autumn":
                    {

                        double zaplata = 0;

                        if (kilometri <= 5000)
                        {
                            zaplata = kilometri * 0.75;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }
                        else if (kilometri > 5000 && kilometri <= 10000)
                        {
                            zaplata = kilometri * 0.95;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }
                        else if (kilometri > 10000 && kilometri <= 20000)
                        {
                            zaplata = kilometri * 1.45;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }


                        break;
                    }


                case "Winter":
                    {

                        double zaplata = 0;

                        if (kilometri <= 5000)
                        {
                            zaplata = kilometri * 1.05;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }
                        else if (kilometri > 5000 && kilometri <= 10000)
                        {
                            zaplata = kilometri * 1.25;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }
                        else if (kilometri > 10000 && kilometri <= 20000)
                        {
                            zaplata = kilometri * 1.45;
                            zaplata = zaplata * 4;
                            zaplata = zaplata - (zaplata * 0.1);
                            Console.WriteLine("{0:F2}", zaplata);
                        }

                        break;
                    }

            }
        }
    }
}
