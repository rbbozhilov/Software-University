using System;

namespace Trade_Commissions
{
    class Program
    {
        static float retur(double a)
        {

            return (float)a;
        }

        static void Main(string[] args)
        {

            string town = Console.ReadLine();
            float komision = float.Parse(Console.ReadLine());
            float sum = 0;

            switch (town)
            {
                case "Sofia":
                    {

                        if (komision >= 0 && komision <= 500)
                        {
                            sum = komision * 5 / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (komision > 500 && komision <= 1000)
                        {
                            sum = komision * 7 / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (komision > 1000 && komision <= 10000)
                        {
                            sum = komision * 8 / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (komision > 10000)
                        {
                            sum = komision * 12 / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }

                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    }


                case "Plovdiv":
                    {
                        if (komision >= 0 && komision <= 500)
                        {
                            sum = komision * retur(5.5) / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (komision > 500 && komision <= 1000)
                        {
                            sum = komision * 8 / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (komision > 1000 && komision <= 10000)
                        {
                            sum = komision * 12 / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (komision > 10000)
                        {
                            sum = komision * retur(14.5) / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }

                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    }

                case "Varna":
                    {
                        if (komision >= 0 && komision <= 500)
                        {
                            sum = komision * retur(4.5) / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (komision > 500 && komision <= 1000)
                        {
                            sum = komision * retur(7.5) / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (komision > 1000 && komision <= 10000)
                        {
                            sum = komision * 10 / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (komision > 10000)
                        {
                            sum = komision * 13 / 100;
                            Console.WriteLine("{0:F2}", sum);
                        }

                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    }

                default:
                    {
                        Console.WriteLine("error");
                        break;
                    }
            }


        }
    }
}
