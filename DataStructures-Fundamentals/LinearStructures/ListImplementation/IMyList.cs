using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementation
{
    public interface IMyList<T>
    {

        public int Capacity { get;  }

        public int Count { get;  }

        void Add(T item);

        bool Remove(T item);

        void RemoveAt(int index);

        bool Contains(T item);

        int IndexOf(T item);

        void Reverse();

        void Insert(int index, T item);



    }
}
