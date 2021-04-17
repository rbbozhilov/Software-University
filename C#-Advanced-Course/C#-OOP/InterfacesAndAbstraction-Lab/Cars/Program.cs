﻿using System;

using Cars.Contracts;
using Cars.Models;


namespace Cars
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(seat.Start());
            Console.WriteLine(seat.Stop());

            Console.WriteLine(tesla.ToString());
            Console.WriteLine(tesla.Start());
            Console.WriteLine(tesla.Stop());


        }
    }
}
