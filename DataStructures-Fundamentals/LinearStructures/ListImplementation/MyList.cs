using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementation
{
    public class MyList<T> : IMyList<T>
    {

        private T[] array;
        private int index;


        public MyList(int capacity = 4)
        {

            this.index = 0;
            this.array = new T[capacity];

        }


        public int Capacity => this.array.Length;

        public int Count => this.index;


        public T this[int i]
        {
            get
            {
                return this.array[i];
            }
            set
            {

                this.array[i] = value;
            }
        }

        public void Add(T item)
        {
            if (this.Capacity == this.Count)
            {
                Grow();
            }

            this.array[index++] = item;


        }

        public void Insert(int index, T item)
        {

            if ((this.index + 1 <= this.Capacity) && (index < this.Count) && (index >= 0))
            {

                this.index++;


                for (int i = this.Count - 1; i > index; i--)
                {
                    this.array[i] = this.array[i-1];
                }

                this.array[index] = item;
            }

        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T item)
        {

            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }


        public bool Remove(T item)
        {
            int indexOfItem = this.IndexOf(item);

            if (indexOfItem >= 0)
            {
                this.RemoveAt(indexOfItem);

                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                for (int i = index; i < this.Count - 1; i++)
                {
                    this.array[i] = this.array[i + 1];
                }
                this.index--;
            }

        }

        public void Reverse()
        {
            T[] copiedArr = this.Copy(this.array);

            for (int i = 0; i < this.Count; i++)
            {
                this.array[i] = copiedArr[this.Count - i - 1];
            }
        }


        private T[] Copy(T[] array)
        {

            T[] newArr = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }

            return newArr;

        }


        private void Grow()
        {
            T[] newArray = new T[this.Capacity * 2];


            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;

        }


    }
}
