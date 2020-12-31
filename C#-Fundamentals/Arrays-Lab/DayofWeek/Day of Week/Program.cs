using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            string[] dayOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


            if (input >= 1 && input <= 7)
            {
                Console.WriteLine(dayOfWeek[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
