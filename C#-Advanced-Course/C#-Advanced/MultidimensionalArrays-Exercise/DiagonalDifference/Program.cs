using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, rows];


            for(int i=0;i<rows;i++)
            {

                int[] currentNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                for(int j=0;j<rows;j++)
                {
                    matrix[i, j] = currentNumbers[j];
                }

            }
            int sumpPimary = 0;
            int sumSecondary = 0;
            int primaryCol = 0;
            int secondaryCol = matrix.GetLength(0) - 1;

            for (int row=0;row<matrix.GetLength(0);row++)
            {
                
                sumpPimary += matrix[row, primaryCol];
                sumSecondary += matrix[row, secondaryCol];

                primaryCol++;
                secondaryCol--;
            }

            int finalSum = Math.Abs(sumpPimary - sumSecondary);

            Console.WriteLine(finalSum);
        }
    }
}
