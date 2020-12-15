using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;

            string text = null;

            while ((text = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(text);

                if (number < min)
                {
                    min = number;
                }

            }

            Console.WriteLine(min);
        }
    }
}
