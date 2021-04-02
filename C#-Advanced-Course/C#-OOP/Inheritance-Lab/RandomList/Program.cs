using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            RandomList list = new RandomList();


            list.Add("13");
            list.Add("312314dsd");
            list.Add("dddddddddddd");
            list.Add("eeeeeeeeeeeeeee");
            list.Add("vvvvvvvvvvvv");

            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());

        }
    }
}
