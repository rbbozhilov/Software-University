﻿using CustomRandomList;
using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

          
                Person person = new Person(name, age);
                Console.WriteLine(person.ToString());
           
               
            



        }
    }
}
