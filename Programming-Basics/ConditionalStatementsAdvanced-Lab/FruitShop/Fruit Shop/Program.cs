using System;

namespace Fruit_Shop
{
    class Program
    {
        static float retur(double a)
        {

            return (float)a;
        }

        static void Main(string[] args)
        {


            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            float kolichestvo = float.Parse(Console.ReadLine());
            float sum = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    {
                        if (fruit == "banana")
                        {
                            sum = kolichestvo * retur(2.50);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "apple")
                        {
                            sum = kolichestvo * retur(1.20);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "orange")
                        {
                            sum = kolichestvo * retur(0.85);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "grapefruit")
                        {
                            sum = kolichestvo * retur(1.45);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "kiwi")
                        {
                            sum = kolichestvo * retur(2.70);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "pineapple")
                        {
                            sum = kolichestvo * retur(5.50);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "grapes")
                        {
                            sum = kolichestvo * retur(3.85);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    }

                case "Saturday":
                case "Sunday":
                    {
                        if (fruit == "banana")
                        {
                            sum = kolichestvo * retur(2.70);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "apple")
                        {
                            sum = kolichestvo * retur(1.25);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "orange")
                        {
                            sum = kolichestvo * retur(0.90);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "grapefruit")
                        {
                            sum = kolichestvo * retur(1.60);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "kiwi")
                        {
                            sum = kolichestvo * retur(3.00);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "pineapple")
                        {
                            sum = kolichestvo * retur(5.60);
                            Console.WriteLine("{0:F2}", sum);
                        }
                        else if (fruit == "grapes")
                        {
                            sum = kolichestvo * retur(4.20);
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
