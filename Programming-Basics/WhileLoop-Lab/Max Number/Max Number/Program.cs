using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;

            string text = null;

            while ((text = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(text);

                if (number > max)
                {
                    max = number;
                }

            }

            Console.WriteLine(max);
        }
    }
}
