using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            else
            {

            }

            if (hours > 23)
            {
                hours -= 24;
            }


            Console.WriteLine("{0}:{1:d2}", hours, minutes);
        }
    }
}
