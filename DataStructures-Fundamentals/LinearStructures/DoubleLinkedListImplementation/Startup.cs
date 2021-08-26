using LinkedListImplementation;
using System;
using System.Diagnostics;

namespace DoubleLinkedList
{
    public class Startup
    {
        static void Main(string[] args)
        {

            DoubleLinkedList<long> doubleLinkedList = new DoubleLinkedList<long>();

            for (long i = 0; i < 100000000; i++)
            {
                doubleLinkedList.AddLast(i);

            }

            var watch = new Stopwatch();

            watch.Start();
            doubleLinkedList.Contains(50000000);
            watch.Stop();
            Console.WriteLine("DoubleLinkedList Time ->  " + watch.Elapsed);

        }
    }
}
