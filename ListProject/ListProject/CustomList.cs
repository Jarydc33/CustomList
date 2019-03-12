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
        int count;
        public int Count { get { return count; } }
        public int Capacity;

        public CustomList()
        {
            items = new T[0];
            count = 0;
            Capacity = 0;
        }
        
        public void Add(T item)
        {
            if(items.Length == count)
            {
                Capacity += 4;
                T[] tempArray = new T[Capacity];
                items = tempArray;
            }

            items[count] = item;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index > count - 1 || index < 0)
                    throw new IndexOutOfRangeException("You can`t access that portion of the list!");
                return items[index];
            }
            set
            {
                if (index > count - 1 || index < 0)
                    throw new IndexOutOfRangeException("You can`t access that portion of the list!");
                items[index] = value;
            }
        }


    }
}
