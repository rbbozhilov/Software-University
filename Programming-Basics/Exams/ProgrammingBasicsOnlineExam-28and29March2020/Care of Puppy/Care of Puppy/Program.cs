using System;

namespace Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int zakupenahrana = int.Parse(Console.ReadLine());

            string text = null;
            int obshtahrana = zakupenahrana * 1000;
            int sum = 0;
            while ((text = Console.ReadLine()) != "Adopted")
            {

                int gramaj = int.Parse(text);

                sum += gramaj;


            }

            if (sum <= obshtahrana)
            {

                int finalSum = obshtahrana - sum;

                Console.WriteLine("Food is enough! Leftovers: {0} grams.", finalSum);


            }
            else
            {

                int finalSum = sum - obshtahrana;

                Console.WriteLine("Food is not enough. You need {0} grams more.", finalSum);

            }
        }
    }
}
