using System;
using System.Linq;

namespace Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for(int row=0;row<rows;row++)
            {

                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = numbers;


            }

            string command = string.Empty;

            while((command=Console.ReadLine()) !="END")
            {

                string[] tokens = command.Split();
                string curretCommand = tokens[0];

                if(curretCommand=="Add")
                {

                    int currentRow = int.Parse(tokens[1]);
                    int currentCol = int.Parse(tokens[2]);
                    int currentValue = int.Parse(tokens[3]);

                    if((currentRow>=0 && currentRow<=rows-1) && (currentCol>=0 && currentCol<=jaggedArray[currentRow].Length-1))
                    {

                        jaggedArray[currentRow][currentCol] += currentValue;

                    }

                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }


                }
                else if(curretCommand=="Subtract")
                {
                    int currentRow = int.Parse(tokens[1]);
                    int currentCol = int.Parse(tokens[2]);
                    int currentValue = int.Parse(tokens[3]);

                    if ((currentRow >= 0 && currentRow <= rows-1) && (currentCol >= 0 && currentCol <= jaggedArray[currentRow].Length-1))
                    {

                        jaggedArray[currentRow][currentCol] -= currentValue;

                    }

                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

            }

            foreach(var items in jaggedArray)
            {

                Console.WriteLine(string.Join(" ",items));

            }

        }
    }
}
