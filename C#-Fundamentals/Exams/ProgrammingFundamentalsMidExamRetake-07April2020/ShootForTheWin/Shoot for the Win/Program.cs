using System;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            string command = string.Empty;
            int countTarget = 0;

            while ((command = Console.ReadLine()) != "End")
            {

                int currentIndex = int.Parse(command);

                if (currentIndex >= 0 && currentIndex < numbers.Length)
                {

                    if (numbers[currentIndex] == -1)
                    {
                        continue;
                    }

                    int currentValue = numbers[currentIndex];
                    numbers[currentIndex] = -1;
                    countTarget++;

                    for (int i = 0; i < numbers.Length; i++)
                    {

                        if (numbers[i] == -1)
                        {
                            continue;
                        }

                        if (numbers[i] > currentValue)
                        {
                            numbers[i] -= currentValue;
                        }
                        else if (numbers[i] <= currentValue)
                        {
                            numbers[i] += currentValue;
                        }



                    }


                }

            }

            Console.Write("Shot targets: {0} -> ", countTarget);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
