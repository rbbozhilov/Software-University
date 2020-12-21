using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int hours1;
            hours1 = hours;
            int k = minutes + 15;
            int helper = 0;

            int lastminute = 0;
            if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
            {
                if (k >= 60)
                {

                    for (int i = minutes; i <= k; i++)
                    {

                        helper = i;

                        if (helper == 60 && i == k)
                        {
                            lastminute = 0;
                            if (hours == 23)
                            {
                                hours = 0;
                            }

                        }

                        else if (helper > 60)
                        {
                            lastminute++;

                        }

                    }

                    if ((k >= 60 || k == 60) && hours == 23)
                    {
                        hours = 0;
                    }



                    if (k >= 60 && hours1 != 23)
                    {
                        hours++;
                    }



                    if (lastminute >= 0 && lastminute < 10)
                    {
                        Console.WriteLine("{0}:0{1}", hours, lastminute);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", hours, lastminute);
                    }
                }
                else
                {
                    if (k >= 0 && k < 10)
                    {
                        Console.WriteLine("{0}:0{1}", hours, k);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", hours, k);
                    }

                }

            }
        }
    }
}
