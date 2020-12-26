using System;

namespace Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int fitnesMembers = int.Parse(Console.ReadLine());

            int counterChest = 0;
            int counterBack = 0;
            int counterLegs = 0;
            int counterAbs = 0;
            int counterProteinShake = 0;
            int counterProteinBar = 0;
            int counterTrained = 0;
            double percentWork = 0;
            double percentProtein = 0;

            for (int i = 0; i < fitnesMembers; i++)
            {


                string text = Console.ReadLine();


                if (text == "Back")
                {

                    counterBack++;
                    counterTrained++;

                }
                else if (text == "Chest")
                {
                    counterChest++;
                    counterTrained++;
                }
                else if (text == "Abs")
                {
                    counterAbs++;
                    counterTrained++;
                }
                else if (text == "Legs")
                {
                    counterLegs++;
                    counterTrained++;
                }
                else if (text == "Protein shake")
                {
                    counterProteinShake++;
                }
                else if (text == "Protein bar")
                {
                    counterProteinBar++;
                }




            }


            percentWork = (double)counterTrained / fitnesMembers * 100;
            percentProtein = (double)(counterProteinBar + counterProteinShake) / fitnesMembers * 100;


            Console.WriteLine("{0} - back\n{1} - chest\n{2} - legs\n{3} - abs\n{4} - protein shake\n{5} - protein bar\n{6:F2}% - work out\n{7:F2}% - protein", counterBack, counterChest, counterLegs, counterAbs, counterProteinShake, counterProteinBar, percentWork, percentProtein);
        }
    }
}
