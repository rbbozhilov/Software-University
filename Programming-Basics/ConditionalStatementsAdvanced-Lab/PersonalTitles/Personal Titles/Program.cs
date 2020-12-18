using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (years >= 16 && gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (years < 16 && gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (years >= 16 && gender == "f")
            {
                Console.WriteLine("Ms.");
            }
            else if (years < 16 && gender == "f")
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
