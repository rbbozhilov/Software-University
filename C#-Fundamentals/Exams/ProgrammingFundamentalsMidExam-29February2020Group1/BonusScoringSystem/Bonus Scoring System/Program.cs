using System;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            double formula = 0;
            double bestBonus = 0;
            int bestAttench = 0;


            for (int i = 0; i < students; i++)
            {

                int attench = int.Parse(Console.ReadLine());

                formula = Math.Ceiling(((double)attench / (double)lectures) * (double)(5 + bonus));

                if (bestBonus <= formula)
                {
                    bestBonus = formula;
                    bestAttench = attench;
                }

            }

            Console.WriteLine("Max Bonus: {0}.", bestBonus);
            Console.WriteLine("The student has attended {0} lectures.", bestAttench);
        }
    }
}
