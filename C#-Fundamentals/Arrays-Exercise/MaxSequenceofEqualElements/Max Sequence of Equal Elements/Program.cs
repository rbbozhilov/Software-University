using System;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            string[] arrayText = text.Split();

            int[] array = new int[arrayText.Length];

            int length = array.Length;


            for (int i = 0; i < length; i++)
            {


                array[i] = int.Parse(arrayText[i]);

            }


            int counterBest = 0;
            int count = 0;
            int bestNumber = 0;
            int index = 0;


            for (int i = 0; i < length; i++)
            {


                for (int j = i; j < length; j++)
                {

                    if (array[i] == array[j])
                    {
                        count++;
                        index = i;
                    }
                    else
                    {

                        break;
                    }


                }

                if (count > counterBest)
                {
                    counterBest = count;
                    bestNumber = array[index];
                }

                count = 0;
            }


            for (int i = 0; i < counterBest; i++)
            {
                Console.Write(bestNumber + " ");
            }

        }
    }
}
