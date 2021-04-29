using Shapes.Models;
using System;

namespace Shapes
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "c")
                {
                    Shape circle = new Circle(5);
                    Console.WriteLine(circle.CalculateArea());
                    Console.WriteLine(circle.CalculatePerimeter());
                    Console.WriteLine(circle.Draw());
                }

                else if (input == "r")
                {
                    Shape rec = new Rectangle(4, 60);
                    Console.WriteLine(rec.CalculateArea());
                    Console.WriteLine(rec.CalculatePerimeter());
                    Console.WriteLine(rec.Draw());
                }


            }


        }
    }
}
