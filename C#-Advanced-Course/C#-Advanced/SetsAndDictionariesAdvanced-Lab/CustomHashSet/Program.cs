using System;


namespace CustomHashSet
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomHashSet<int> numbers = new CustomHashSet<int>();

            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(23);
          

            Console.WriteLine(numbers.Remove(666));
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Remove(23));
            Console.WriteLine(numbers.Contains(111));

        }
    }
}
