using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");
            string take = input[input.Length - 1];
            string[] tokens = take.Split(".");
            string name = tokens[0];
            string ext = tokens[1];

            Console.WriteLine("File name: {0}\nFile extension: {1}", name, ext);
        }
    }
}
