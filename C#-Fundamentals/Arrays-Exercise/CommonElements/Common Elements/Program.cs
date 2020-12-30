using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();

            string[] firstArrray = firstText.Split();
            string[] secondArray = secondText.Split();
            int counter = 0;

            string[] finalArray = new string[secondArray.Length];


            for (int i = 0; i < secondArray.Length; i++)
            {

                for (int j = 0; j < firstArrray.Length; j++)
                {


                    if (secondArray[i] == firstArrray[j])
                    {

                        finalArray[i] = secondArray[i];
                        counter++;

                    }
                }

            }


            for (int i = 0; i < finalArray.Length; i++)
            {
                if (finalArray[i] == null)
                {
                    continue;
                }
                Console.Write(finalArray[i] + " ");
            }
        }
    }
}
