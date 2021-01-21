using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(SumOfStrings(strings[0], strings[1]));

        }

        static int SumOfStrings(string first, string second)
        {
            int sum = 0;

            if (first.Length > second.Length)
            {
                int lengthOfSecond = second.Length;


                for (int i = 0; i < first.Length; i++)
                {

                    if (lengthOfSecond > i)
                    {
                        sum += first[i] * second[i];
                    }

                    else
                    {
                        sum += first[i];
                    }

                }


            }

            else
            {

                int lengthOfFirst = first.Length;


                for (int i = 0; i < second.Length; i++)
                {

                    if (lengthOfFirst > i)
                    {
                        sum += first[i] * second[i];
                    }

                    else
                    {
                        sum += second[i];
                    }

                }


            }


            return sum;
        }
    }
}
