using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfTree
{
    public class Trees<T>
    {
        public List<T> DFS(Node<T> root)
        {
            var list = new List<T>();

            foreach(var child in root.Children)
            {
               list.AddRange(DFS(child));
            }
            list.Add(root.Value);

            return list;
        }


        public List<Node<T>> BFS(Node<T> root)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            List<Node<T>> list = new List<Node<T>>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {

                Node<T> currentNode = queue.Dequeue();
                list.Add(currentNode);

                foreach(var children in currentNode.Children)
                {
                    queue.Enqueue(children);
                }


            }

            return list;
        }

    }
}
