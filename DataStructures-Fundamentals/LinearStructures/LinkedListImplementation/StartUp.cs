using System;

namespace LinkedListImplementation
{
   public class StartUp
    {
        static void Main(string[] args)
        {


            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                linkedList.AddLast(i);
            }

            var currentNode = linkedList.Head;

            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
                
            }

            Console.WriteLine(linkedList.Tail.Value);

        }
    }
}
