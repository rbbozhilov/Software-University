﻿using System;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double Lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Height = double.Parse(Console.ReadLine());
            double Volume = (Lenght * Width * Height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", Volume);
        }
    }
}
