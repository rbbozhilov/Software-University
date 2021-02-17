using System;
using System.Linq;


namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];
            bool sameLength = false;

            for (int row = 0; row < rows; row++)
            {

                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                matrix[row] = new int[numbers.Length];

                for (int col = 0; col < numbers.Length; col++)
                {
                    matrix[row][col] = numbers[col];
                }


            }


            for (int row = 0; row < matrix.Length - 1; row++)
            {

                if (matrix[row].Length == matrix[row + 1].Length)
                {

                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }

                }

                else
                {

                    for (int col = 0; col < matrix[row].Length; col++)
                    {

                        matrix[row][col] /= 2;


                    }

                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {

                        matrix[row + 1][col] /= 2;

                    }


                }


            }


            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "End")
            {

                string[] tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];
                int currentRow = int.Parse(tokens[1]);
                int currentCol = int.Parse(tokens[2]);
                int currentValue = int.Parse(tokens[3]);

                if (currentRow >= 0 && currentRow < matrix.Length && currentCol >= 0 && currentCol < matrix[currentRow].Length)
                {

                    if (currentCommand == "Add")
                    {
                        matrix[currentRow][currentCol] += currentValue;
                    }

                    else if (currentCommand == "Subtract")
                    {
                        matrix[currentRow][currentCol] -= currentValue;
                    }


                }


            }

            for (int row = 0; row < matrix.Length; row++)
            {

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
