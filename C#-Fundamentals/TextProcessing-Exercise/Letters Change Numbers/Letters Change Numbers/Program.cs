using System;
using System.Text;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {



                StringBuilder number = new StringBuilder();

                for (int j = 0; j < input[i].Length; j++)
                {

                    char currentChar = input[i][j];

                    if (char.IsDigit(currentChar))
                    {
                        number.Append(currentChar);
                    }


                }

                int currentNumber = int.Parse(number.ToString());
                int indexOfLast = input[i].Length;
                char firstChar = input[i][0];
                char lastChar = input[i][indexOfLast - 1];
                decimal theSum = 0;

                if (char.IsUpper(firstChar))
                {

                    int position = 0;

                    position = firstChar - 65;
                    position++;

                    theSum = currentNumber / (decimal)position;



                }

                else
                {


                    int position = 0;

                    position = firstChar - 97;
                    position++;

                    theSum = currentNumber * (decimal)position;



                }

                if (char.IsUpper(lastChar))
                {

                    int position = 0;

                    position = lastChar - 65;
                    position++;

                    theSum -= (decimal)position;



                }

                else
                {


                    int position = 0;

                    position = lastChar - 97;
                    position++;

                    theSum += (decimal)position;



                }

                sum += theSum;

            }


            Console.WriteLine("{0:F2}", sum);
        }
    }
}
