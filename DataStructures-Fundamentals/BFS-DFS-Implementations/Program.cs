using System;

namespace ExampleOfTree
{
    class Program
    {
        static void Main(string[] args)
        {

            Node<int> root = new Node<int>(7,
                new Node<int>(19,
                   new Node<int>(1),
                   new Node<int>(12),
                   new Node<int>(31)
                ),
                new Node<int>(21),
                new Node<int>(14,
                  new Node<int>(23),
                  new Node<int>(6)
                )

                );

            Trees<int> tree = new Trees<int>();

            Console.WriteLine("Printing Tree with BFS algorithm");
            var listOfTree = tree.BFS(root);
            
            foreach (var node in listOfTree)
            {
                Console.WriteLine(node.Value);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Printing Tree with DFS algorithm");
            var listDFS = tree.DFS(root);

            foreach (var node in listDFS)
            {
                Console.WriteLine(node);
            }

        }
    }
}
