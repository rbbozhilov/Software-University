using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goalreach = 10000;
            int steps = 0;
            int sum = 0;
            int goalsteps = 0;
            string text = null;

            while ((text = Console.ReadLine()) != "Going home")
            {

                steps = int.Parse(text);

                sum += steps;

                if (sum >= goalreach)
                {
                    goalsteps = sum - goalreach;
                    Console.WriteLine("Goal reached! Good job!\n{0} steps over the goal!", goalsteps);
                    System.Environment.Exit(1);
                }

            }

            steps = int.Parse(Console.ReadLine());
            sum += steps;

            goalsteps = sum - goalreach;
            if (sum >= goalreach)
            {
                Console.WriteLine("Goal reached! Good job!\n{0} steps over the goal!", goalsteps);
            }
            else
            {
                goalsteps = Math.Abs(sum - goalreach);
                Console.WriteLine("{0} more steps to reach goal.", goalsteps);
            }
        }
    }
}
