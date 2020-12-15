using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int maxsum = 0;
            int num = 0;
            int othersum = 0;

            int[] arr = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > maxsum)
                {
                    maxsum = arr[i];
                }




            }
            int helper = 0;

            for (int i = 0; i < numbers; i++)
            {


                if (arr[i] == maxsum && helper == 0)
                {
                    helper++;
                    continue;
                }
                else
                {
                    othersum += arr[i];

                }

            }

            if (othersum == maxsum)
            {
                Console.WriteLine("Yes\nSum = {0}", maxsum);

            }
            else
            {

                Console.WriteLine("No\nDiff = {0}", Math.Abs(othersum - maxsum));

            }

        }
    }
}
