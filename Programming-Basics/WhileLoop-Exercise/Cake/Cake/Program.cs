using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int razmer = int.Parse(Console.ReadLine());
            int razmer1 = int.Parse(Console.ReadLine());
            int obshtrazmer = razmer * razmer1;
            int sum = 0;

            string text = null;
            int k = 0;
            while ((text = Console.ReadLine()) != "STOP")
            {

                int part = int.Parse(text);

                sum += part;

                if (sum >= obshtrazmer)
                {
                    int more = Math.Abs(sum - obshtrazmer);
                    Console.WriteLine("No more cake left! You need {0} pieces more.", more);
                    k = 1;
                    break;
                }


            }

            if (k == 0)
            {
                int more = Math.Abs(sum - obshtrazmer);
                Console.WriteLine("{0} pieces are left.", more);
            }
        }
    }
}
