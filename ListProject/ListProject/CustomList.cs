using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    public class CustomList<T>
    {
        T[] items;
        public int Count;
        public int Capacity;

        public CustomList()
        {
            items = new T[0];
            Count = 0;
            Capacity = 0;
        }
        
        public void Add(T item)
        {
            if(items.Length == Count)
            {
                Capacity += 4;
                T[] tempArray = new T[Capacity];
                items = tempArray;
            }

            items[Count] = item;
            Count++;
        }

        public T this[int index]
        {
            get
            {
                if (index > Count - 1)
                    throw new IndexOutOfRangeException();
                return items[index];
            }
            set
            {
                if (index > Count - 1)
                    throw new IndexOutOfRangeException();
                items[index] = value;
            }
        }


    }
}
