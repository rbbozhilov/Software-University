using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int sum = 0;
            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            for(int row=0;row<matrix.GetLength(0);row++)
            {

                int[] currentNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


                for(int col=0;col<matrix.GetLength(1);col++)
                {

                    matrix[row, col] = currentNumbers[col];


                }


            }

            for(int row=0;row<matrix.GetLength(0)-2;row++)
            {


                for(int col=0;col<matrix.GetLength(1)-2; col++)
                {

                    if(Checking(matrix,row,col))
                    {

                        sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                        if(bestSum<sum)
                        {
                            bestSum = sum;

                            bestCol = col;
                            bestRow = row;

                        }

                        sum = 0;

                    }


                }


            }

            Console.WriteLine("Sum = {0}",bestSum);

            Console.WriteLine("{0} {1} {2}\n{3} {4} {5}\n{6} {7} {8}\n", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2], matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2], matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);


        }

         static bool Checking(int[,] matrix, int row, int col)
        {

            row += 2;
            col += 2;
            if (row <= matrix.GetLength(0) && col <= matrix.GetLength(1))
            {
                return true;
            }


            return false;
        }

    }
}
