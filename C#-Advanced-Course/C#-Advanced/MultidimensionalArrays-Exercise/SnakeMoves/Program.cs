using System;
using System.Linq;
using System.Text;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] snakeMoves = new int[sizes[0], sizes[1]];

            string snake = Console.ReadLine();
            StringBuilder snakePath = new StringBuilder();
            int counter = 0;

            for (int row = 0; row < snakeMoves.GetLength(0); row++)
            {

                if (row % 2 == 0)
                {

                    for (int col = 0; col < snakeMoves.GetLength(1); col++)
                    {

                        if(counter==snake.Length)
                        {
                            counter = 0;
                        }

                        snakeMoves[row, col] = snake[counter];

                        counter++;

                    }

                }

                else
                {

                    for(int col=snakeMoves.GetLength(1)-1;col>=0;col--)
                    {

                        if(counter==snake.Length)
                        {
                            counter = 0;
                        }

                        snakeMoves[row, col] = snake[counter];

                        counter++;
                    }

                }


            }

            for(int row = 0;row<snakeMoves.GetLength(0);row++)
            {

               for(int col=0;col<snakeMoves.GetLength(1);col++)
                {
                    Console.Write((char)snakeMoves[row,col]);
                }
                Console.WriteLine();

            }


        }
    }
}
