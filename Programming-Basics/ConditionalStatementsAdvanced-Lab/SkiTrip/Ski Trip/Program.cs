using System;

namespace Ski_Trip
{
    class Program
    {
        static float retur(double a)
        {

            return (float)a;
        }

        static void Main(string[] args)
        {


            int day = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string mark = Console.ReadLine();
            float sum = 0;


            day--;


            if (room == "room for one person")
            {
                sum = 18 * day;
                if (mark == "positive")
                {

                    sum += (sum * 25 / 100);
                    Console.WriteLine("{0:F2}", sum);
                }
                else if (mark == "negative")
                {
                    sum -= retur(18.00) * 10 / 100;
                    Console.WriteLine("{0:F2}", sum);
                }

            }

            else if (room == "apartment")
            {

                sum = 25 * day;

                if (day < 10)
                {

                    sum -= (sum * 30 / 100);

                    if (mark == "positive")
                    {

                        sum += (sum * 25 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                    else if (mark == "negative")
                    {
                        sum -= (sum * 10 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }


                }
                else if (day > 10 && day < 15)
                {
                    sum -= (sum * 35 / 100);


                    if (mark == "positive")
                    {

                        sum += (sum * 25 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                    else if (mark == "negative")
                    {
                        sum -= (sum * 10 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                }
                else if (day > 15)
                {
                    sum -= (sum * 50 / 100);
                    if (mark == "positive")
                    {

                        sum += (sum * 25 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                    else if (mark == "negative")
                    {
                        sum -= (sum * 10 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                }



            }
            else if (room == "president apartment")
            {

                sum = 35 * day;

                if (day < 10)
                {

                    sum -= (sum * 10 / 100);

                    if (mark == "positive")
                    {

                        sum += (sum * 25 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                    else if (mark == "negative")
                    {
                        sum -= (sum * 10 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }


                }
                else if (day > 10 && day < 15)
                {
                    sum -= (sum * 15 / 100);


                    if (mark == "positive")
                    {

                        sum += (sum * 25 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                    else if (mark == "negative")
                    {
                        sum -= (sum * 10 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                }
                else if (day > 15)
                {
                    sum -= (sum * 20 / 100);
                    if (mark == "positive")
                    {

                        sum += (sum * 25 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                    else if (mark == "negative")
                    {
                        sum -= (sum * 10 / 100);
                        Console.WriteLine("{0:F2}", sum);
                    }
                }


            }



        }
    }
}
