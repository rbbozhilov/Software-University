using System;
using System.Linq;

namespace SumAllNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lengthOfArray = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[lengthOfArray[0], lengthOfArray[1]];

            for(int row=0;row<matrix.GetLength(0);row++)
            {

                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col=0;col<matrix.GetLength(1);col++)
                {

                    matrix[row, col] = rowData[col];

                }

            }

            int sum = 0;

            for(int row=0;row<matrix.GetLength(0);row++)
            {

               for(int col=0;col<matrix.GetLength(0);col++)
                {
                    sum += matrix[row, col];
                }


            }


            Console.WriteLine("{0}\n{1}\n{2}",matrix.GetLength(0),matrix.GetLength(1),sum);

        }
    }
}
