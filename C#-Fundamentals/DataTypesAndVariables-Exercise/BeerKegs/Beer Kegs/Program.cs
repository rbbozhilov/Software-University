using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string best = string.Empty;
            float bestSum = float.MinValue;

            for (int i = 0; i < lines; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float sum = ((float)Math.PI * radius * radius) * height;

                if (sum > bestSum)
                {
                    bestSum = sum;
                    best = model;
                }

            }

            Console.WriteLine(best);
        }
    }
}
