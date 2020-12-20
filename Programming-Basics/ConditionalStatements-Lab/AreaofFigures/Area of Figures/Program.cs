using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();

            if (choice == "square")
            {
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine(a * a);
            }
            else if (choice == "rectangle")
            {
                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (choice == "circle")
            {
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", 3.1415926536 * a * a);
            }
            else if (choice == "triangle")
            {

                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());

                Console.WriteLine((a * b) / 2);

            }
        }
    }
}
