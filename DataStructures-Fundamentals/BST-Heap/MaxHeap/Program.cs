using System;

namespace MaxHeap
{
   public class Program
    {
        static void Main(string[] args)
        {
            MaxHeap<int> maxheap = new MaxHeap<int>();

            maxheap.Add(2);
            maxheap.Add(1);
            maxheap.Add(10);
            maxheap.Add(11);
            maxheap.Add(22);
            maxheap.Add(-5);
            maxheap.Add(4);
        

            Console.WriteLine(maxheap.PeekMax());
           

        }
    }
}
