using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = numbers[col];

                }

            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "swap" && tokens.Length == 5)
                {
                    int firstRow = int.Parse(tokens[1]);
                    int firstCol = int.Parse(tokens[2]);
                    int secondRow = int.Parse(tokens[3]);
                    int secondCol = int.Parse(tokens[4]);

                    if (firstRow >= 0 && firstCol < matrix.GetLength(1) && firstRow < matrix.GetLength(0) && secondRow >= 0 && secondRow < matrix.GetLength(0) && secondCol >= 0 && secondCol < matrix.GetLength(1))
                    {

                        string temp = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = temp;

                        for(int row=0;row<matrix.GetLength(0);row++)
                        {
                            for(int col=0;col<matrix.GetLength(1);col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                       

                    }

                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
