using System;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] stringArray = text.Split();
            string helper = string.Empty;
            int times = int.Parse(Console.ReadLine());


            for (int i = 0; i < times; i++)
            {

                helper = stringArray[0];
                for (int j = 0; j < stringArray.Length - 1; j++)
                {


                    stringArray[j] = stringArray[j + 1];


                }

                stringArray[stringArray.Length - 1] = helper;

            }

            for (int i = 0; i < stringArray.Length; i++)
            {


                Console.Write(stringArray[i] + " ");


            }
        }
    }
}
