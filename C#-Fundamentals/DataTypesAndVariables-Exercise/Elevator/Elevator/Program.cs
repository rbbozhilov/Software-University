using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling((double)people / (double)capacity);
            int remainder = people % capacity;


            Console.WriteLine(courses);
        }
    }
}
