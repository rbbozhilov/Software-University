using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int produljitelnostserial = int.Parse(Console.ReadLine());
            int produljitelnostpochivka = int.Parse(Console.ReadLine());



            double vremeobed = (double)produljitelnostpochivka * 1 / 8;

            double vremeotdih = (double)produljitelnostpochivka * 1 / 4;

            double otherTime = produljitelnostpochivka - vremeobed - vremeotdih;


            if (otherTime >= produljitelnostserial)
            {
                otherTime = otherTime - produljitelnostserial;
                Console.WriteLine("You have enough time to watch {0} and left with {1} minutes free time.", name, Math.Ceiling(otherTime));
            }
            else
            {
                Console.WriteLine("You don't have enough time to watch {0}, you need {1} more minutes.", name, Math.Ceiling(Math.Abs(otherTime - produljitelnostserial)));
            }
        }
    }
}
