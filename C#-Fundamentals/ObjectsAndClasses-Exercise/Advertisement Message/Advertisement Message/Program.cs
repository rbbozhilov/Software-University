using System;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());


            Random rnd = new Random();

            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };


            string message = string.Empty;


            for (int i = 0; i < number; i++)
            {


                message += phrases[rnd.Next(0, phrases.Length)] + " ";
                message += events[rnd.Next(0, events.Length)] + " ";
                message += authors[rnd.Next(0, events.Length)] + " - ";
                message += cities[rnd.Next(0, cities.Length)];

                Console.WriteLine(message);

                message = string.Empty;

            }





        }
    }
}
