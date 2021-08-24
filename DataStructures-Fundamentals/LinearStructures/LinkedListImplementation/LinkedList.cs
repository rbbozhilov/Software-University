using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
   public class LinkedList<T>
    {

        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public Node<T> Previous { get; set; }

        public void Add(T element)
        {

            Node<T> newHead = new Node<T>(element);
            newHead.Next = this.Head;

            if(this.Head == null)
            {
                this.Tail = newHead;
            }

            this.Head = newHead;


        }

        public Node<T> RemoveFirst()
        {
            var oldHead = this.Head;
            this.Head = this.Head.Next;

            if(this.Head == null)
            {
                this.Tail = null;
            }

            return oldHead ;

        }

        public void AddLast(T element)
        {
            var lastElement = new Node<T>(element);

            if(this.Tail == null)
            {
                this.Head = lastElement;
                this.Tail = lastElement;
            }


            this.Tail.Next = lastElement;
            this.Tail = lastElement;

        }

     
    }
}
