using System;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometra = int.Parse(Console.ReadLine());
            if (kilometra < 1 || kilometra > 5000)
            {
                Console.WriteLine("Wrong number");
            }
            else
            {
                string text = Console.ReadLine();

                double sumtaxiday = (double)0.70 + 0.79 * kilometra;
                double sumautobusday = (double)0.09 * kilometra;
                double sumvlakday = (double)0.06 * kilometra;
                double sumtaxinight = (double)0.70 + 0.90 * kilometra;

                switch (text)
                {

                    case "day":
                        {

                            if (kilometra < 20)
                            {

                                Console.WriteLine("{0:F2}", sumtaxiday);
                            }
                            else if (kilometra >= 20 && kilometra < 100)
                            {

                                if (sumautobusday < sumtaxiday)
                                {
                                    Console.WriteLine("{0:F2}", sumautobusday);
                                }
                                else
                                {
                                    Console.WriteLine("{0:F2}", sumtaxiday);
                                }

                            }
                            else if (kilometra >= 100)
                            {

                                if (sumvlakday < sumtaxiday && sumvlakday < sumautobusday)
                                {
                                    Console.WriteLine("{0:F2}", sumvlakday);
                                }
                                else if (sumtaxiday < sumvlakday && sumtaxiday < sumautobusday)
                                {
                                    Console.WriteLine("{0:F2}", sumtaxiday);
                                }
                                else if (sumautobusday < sumtaxiday && sumautobusday < sumvlakday)
                                {
                                    Console.WriteLine("{0:F2}", sumautobusday);
                                }



                            }

                            break;
                        }

                    case "night":
                        {
                            if (kilometra < 20)
                            {

                                Console.WriteLine("{0:F2}", sumtaxinight);
                            }
                            else if (kilometra >= 20 && kilometra < 100)
                            {
                                if (sumautobusday < sumtaxinight)
                                {
                                    Console.WriteLine("{0:F2}", sumautobusday);
                                }
                                else
                                {
                                    Console.WriteLine("{0:F2}", sumtaxinight);
                                }
                            }
                            else if (kilometra >= 100)
                            {
                                if (sumvlakday < sumtaxinight && sumvlakday < sumautobusday)
                                {
                                    Console.WriteLine("{0:F2}", sumvlakday);
                                }
                                else if (sumtaxinight < sumvlakday && sumtaxinight < sumautobusday)
                                {
                                    Console.WriteLine("{0:F2}", sumtaxinight);
                                }
                                else if (sumautobusday < sumtaxinight && sumautobusday < sumvlakday)
                                {
                                    Console.WriteLine("{0:F2}", sumautobusday);
                                }
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong word");
                            break;
                        }
                }
            }
        }
    }
}
