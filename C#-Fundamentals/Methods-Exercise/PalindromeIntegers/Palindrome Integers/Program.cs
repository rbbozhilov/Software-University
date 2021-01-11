using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void GetArray(string text, int[] array)
        {

            int currentNumber = 0;
            int result = int.Parse(text);
            int count = 0;

            while (result != 0)
            {
                currentNumber = result;

                currentNumber %= 10;
                array[count] = currentNumber;
                result /= 10;
                count++;
            }

        }


        static bool Palindrome(int[] array)
        {

            bool flag = true;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] != array[array.Length - i - 1])
                {
                    flag = false;
                }


            }

            return flag;
        }

        static void Main(string[] args)
        {

            string text = string.Empty;

            while ((text = Console.ReadLine()) != "END")
            {

                int[] array = new int[text.Length];
                GetArray(text, array);
                bool result = Palindrome(array);
                if (result)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }
    }
}
