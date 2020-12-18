using System;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string typee = Console.ReadLine();


            if (typee == "banana" || typee == "apple" || typee == "kiwi" || typee == "cherry" || typee == "lemon" || typee == "grapes")
            {
                Console.WriteLine("fruit");
            }


            else if (typee == "tomato" || typee == "cucumber" || typee == "pepper" || typee == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
