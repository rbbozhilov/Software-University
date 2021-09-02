using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
  public  class BST<T> where T : IComparable<T>
    {

        public BST(Node<T> root)
        {
            this.Root = root;
        }

        public Node<T> Root { get; set; }

        public void Insert(T value, Node<T> currentNode)
        {

            if (currentNode.Value.CompareTo(value) > 0)
            {


                if (currentNode.LeftChild == null)
                {
                    currentNode.LeftChild = new Node<T>(value);
                    return;
                }
                Insert(value, currentNode.LeftChild);
            }
            else
            {
                if (currentNode.RightChild == null)
                {
                    currentNode.RightChild = new Node<T>(value);
                    return;
                }
                Insert(value, currentNode.RightChild);
            }
        }
    }
}
