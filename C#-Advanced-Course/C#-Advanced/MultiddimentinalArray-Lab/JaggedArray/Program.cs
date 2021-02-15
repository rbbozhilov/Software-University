using System;
using System.Linq;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for(int i=0;i<n;i++)
            {

                int elements = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[elements];

                int[] currentElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = currentElements;


            }


            for(int row=0;row<jaggedArray.Length;row++)
            {

                for(int col=0;col<jaggedArray[row].Length;col++)
                {

                    Console.Write(jaggedArray[row][col] + " ");

                }
                Console.WriteLine();
            }


        }
    }
}
