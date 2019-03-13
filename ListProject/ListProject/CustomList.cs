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
                for(int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
            
            items[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            bool isTrue = false;

            for(int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    int j = i;
                    do
                    {
                        items[j] = items[j + 1];
                        j++;
                    } while (j < count);
                    count--;
                    i--;
                    isTrue = true;
                }
            }
            return isTrue;

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
