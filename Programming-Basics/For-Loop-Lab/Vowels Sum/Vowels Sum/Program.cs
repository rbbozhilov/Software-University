using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string glasna = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < glasna.Length; i++)
            {

                if (glasna[i] == 'e')
                {
                    sum += 2;
                }
                else if (glasna[i] == 'a')
                {
                    sum += 1;
                }
                else if (glasna[i] == 'i')
                {
                    sum += 3;
                }
                else if (glasna[i] == 'o')
                {
                    sum += 4;
                }
                else if (glasna[i] == 'u')
                {
                    sum += 5;
                }


            }

            Console.WriteLine(sum);
        }
    }
}
