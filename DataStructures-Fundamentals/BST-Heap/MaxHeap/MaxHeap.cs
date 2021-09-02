using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxHeap
{
    public class MaxHeap<T> where T : IComparable<T>
    {

        private List<T> heap;

        public MaxHeap()
        {
            this.heap = new List<T>();
        }

        public int Size => heap.Count;

        public void Add(T element)
        {
            this.heap.Add(element);
            Heapify(this.Size - 1);

        }

        public T PeekMax() => this.heap[0];

      


        private void Heapify(int index)
        {

            if (index == 0) return;

            int parentIndex = (index - 1) / 2;

            if (this.heap[index].CompareTo(this.heap[parentIndex]) > 0)
            {
                T temp = this.heap[index];
                this.heap[index] = this.heap[parentIndex];
                this.heap[parentIndex] = temp;
                Heapify(parentIndex);
            }

        }



    }
}
