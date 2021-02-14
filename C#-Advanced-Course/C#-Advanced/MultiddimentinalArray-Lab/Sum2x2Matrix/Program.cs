using System;
using System.Linq;

namespace Sum2x2Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lengthOfArray = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[lengthOfArray[0], lengthOfArray[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = rowData[col];

                }

            }

            int bestSum = 0;
            int currentSum = 0;
            int bestRow = 0;
            int bestCol = 0;
            for(int row=0;row<matrix.GetLength(0)-1;row++)
            {
                for(int col=0;col<matrix.GetLength(1)-1;col++)
                {

                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if(bestSum<currentSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }


                }
            }

            Console.WriteLine("{0} {1}\n{2} {3}\n{4}",matrix[bestRow,bestCol],matrix[bestRow,bestCol+1],matrix[bestRow+1,bestCol],matrix[bestRow+1,bestCol+1],bestSum);


        }
    }
}
