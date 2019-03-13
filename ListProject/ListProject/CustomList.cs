using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        T[] items;
        int count;
        public int Count { get { return count; } }
        public int Capacity;
        public string MyString { get; set; }

        public CustomList()
        {
            items = new T[0];
            count = 0;
            Capacity = 0;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            for(int index = 0; index < count; index++)
            {
                yield return items[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            
            if(items.Length == count)
            {
                Capacity += 4;
                T[] tempArray = new T[Capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
            
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {

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
                }
            }

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

        public override string ToString()
        {       
            
            for (int i = 0; i < count; i++)
            {
                MyString += items[i];
            }

            return MyString;

        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();

            for(int i = 0; i < list1.count; i++)
            {
                newList.Add(list1[i]);
            }
            for(int i = 0; i < list2.count; i++)
            {
                newList.Add(list2[i]);
            }

            return newList;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            for (int i = 0; i < list2.count; i++)
            {
                list1.Remove(list2[i]);
            }
            return list1;
        }

        public CustomList<T> Zip(CustomList<T> addList)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < count && i < addList.count; i++)
            {
                newList.Add(items[i]);
                newList.Add(addList[i]);
                if(count != addList.count)
                {
                    if(i+1 == count)
                    {
                        for(int j = i+1; j< addList.count; j++)
                        {
                            newList.Add(addList[j]);
                        }
                        
                    }
                    else if(i+1 == addList.count)
                    {
                        for (int j = i+1; j < count; j++)
                        {
                            newList.Add(items[j]);
                        }
                    }
                }
            }

            return newList;
        }

        public void Sort()
        {
           
            for(int i = 0; i < count - 1; i++)
            {
                for(int j = i + 1; j > 0; j--)
                {
                    if(items[j-1].CompareTo(items[j]))
                    {
                        int temp = (items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }
                
    }

    public class Test
    {
        public int score;
        public string name;
        
        public Test(int newScore, string myName)
        {
            score = newScore;
            name = myName;
        }
    }
}
