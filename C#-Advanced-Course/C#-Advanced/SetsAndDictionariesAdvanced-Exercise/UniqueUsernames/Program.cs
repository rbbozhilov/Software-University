﻿using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for(int i=0;i<n;i++)
            {

                string currentName = Console.ReadLine();

                names.Add(currentName);

            }


            foreach(var items in names)
            {
                Console.WriteLine(items);
            }


        }
    }
}
