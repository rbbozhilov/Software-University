using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {

        private int count = 0;

        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Count => this.count;


        //Complexity - Constant O(1)
        public void AddFirst(T item)
        {

            if (this.count == 0)
            {
                this.AddFirstItem(item);
                return;
            }

            var newItem = new Node<T>(item);
            var oldHead = this.Head;
            oldHead.Previous = newItem;

            this.Head = newItem;
            this.Head.Next = oldHead;
            this.count++;

        }

        //Complexity -> Constant O(1)
        public void AddLast(T item)
        {

            if (this.count == 0)
            {
                this.AddFirstItem(item);
                return;
            }

            var newItem = new Node<T>(item);
            var oldTail = this.Tail;

            oldTail.Next = newItem;
            this.Tail = newItem;
            this.Tail.Previous = oldTail;
            this.count++;

        }

        //Complexity - Constant O(1)
        public T RemoveFirst()
        {

            this.CheckCount();

            var oldNode = this.Head;
            this.Head = oldNode.Next;
            this.Head.Previous = null;

            this.count--;
            return oldNode.Value;

        }

        //Complexity - Constant O(1)
        public T RemoveLast()
        {
            this.CheckCount();

            var lastNode = this.Tail;
            this.Tail = lastNode.Previous;
            this.Tail.Next = null;

            return lastNode.Value;

        }

        //Complexity -> Linear O(n)
        public bool Contains(T item)
        {
            var currentFirstNode = this.Head;


            for (int i = 0; i < this.count; i++)
            {

                if (currentFirstNode.Value.Equals(item))
                {
                    return true;
                }

                currentFirstNode = currentFirstNode.Next;


            }

            return false;
        }


        //Complexity - Constant O(1)
        public T GetFirst()
        {
            return this.Head.Value;
        }


        //Complexity - Constant O(1)
        public T GetLast()
        {
            return this.Tail.Value;
        }

        
        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.Head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();


        //Complexity - Constant O(1)
        private void AddFirstItem(T item)
        {
            var newItem = new Node<T>(item);
            this.Head = newItem;
            this.Tail = newItem;

            this.count++;

        }

        private void CheckCount()
        {

            if (this.count == 0)
            {
                throw new InvalidOperationException();
            }

        }

    }
}
