using System;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] stringArray = text.Split();


            int[] integerArray = new int[stringArray.Length];





            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = int.Parse(stringArray[i]);


            }

            int length = integerArray.Length;

            for (int i = 0; i < length; i++)
            {
                bool flag = true;

                for (int j = i + 1; j < length; j++)
                {

                    if (integerArray[i] <= integerArray[j])
                    {
                        flag = false;

                    }

                }

                if (flag)
                {
                    Console.Write(integerArray[i] + " ");
                }


            }
        }
    }
}
