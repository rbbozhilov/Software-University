using System;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstArrayInput = Console.ReadLine();
            string secondArrayInput = Console.ReadLine();


            string[] firstArray = firstArrayInput.Split();
            string[] secondArray = secondArrayInput.Split();


            int[] firstArrayNumbers = new int[firstArray.Length];
            int[] secondArrayNumbers = new int[secondArray.Length];


            bool same = true;
            int catcher = 0;
            int sum = 0;

            for (int i = 0; i < firstArrayNumbers.Length; i++)
            {

                firstArrayNumbers[i] = int.Parse(firstArray[i]);
                secondArrayNumbers[i] = int.Parse(secondArray[i]);

                if (firstArrayNumbers[i] != secondArrayNumbers[i])
                {
                    same = false;
                    catcher = i;
                    break;
                }
                else
                {
                    sum += firstArrayNumbers[i];
                }

            }


            if (same)
            {
                Console.WriteLine("Arrays are identical. Sum: {0}", sum);
            }
            else
            {
                Console.WriteLine("Arrays are not identical. Found difference at {0} index", catcher);
            }
        }
    }
}
