using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfTree
{
    public class Node<T>
    {

        public Node(T value , params Node<T>[] children)  
        {
            this.Value = value;
            this.Children = children.ToList();
        }
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }


    }
}
