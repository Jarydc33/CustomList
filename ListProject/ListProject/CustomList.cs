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
        //StringBuilder myStringBuilder = new StringBuilder(null);

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
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            
            if(items.Length == count)
            {
                Capacity += 4;
                T[] tempArray = new T[Capacity];

                //foreach (T stuff in items)
                //{
                //    tempArray = items;
                //}
                //items = tempArray;
                for (int i = 0; i < count; i++)
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

        public override string ToString()
        {            
            for (int i = 0; i < count; i++)
            {
                MyString += items[i];
                //myStringBuilder.Append(items[i]);
            }
            //myStringBuilder.ToString();
            return MyString;
            //return myStringBuilder;    

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
            CustomList<T> newList = new CustomList<T>();

            for(int i = 0; i < list2.count; i++)
            {
                list1.Remove(list2[i]);
            }
            newList = list1;
            return newList;
        }

        public CustomList<T> Zip(CustomList<T> addList)
        {
            int actualLength = 0;
            int longer = 0;
            int tester = 0;
            CustomList<T> newList = new CustomList<T>();

            if (count == addList.count)
            {
                actualLength = addList.count;
            }
            else if (count > addList.count)
            {
                actualLength = addList.count;
                longer = count - addList.count;
                tester = 1;
            }
            else
            {
                actualLength = count;
                longer = addList.count - count;
                tester = 2;
            }

            for (int i = 0; i < actualLength; i++)
            {
                newList.Add(items[i]);
                newList.Add(addList[i]);
            }

            if (tester == 1)
            {
                for (int i = longer+1; i < count; i++)
                {
                    newList.Add(items[i]);
                }
            }
            else if (tester == 2)
            {
                for (int i = longer+1; i < addList.count; i++)
                {
                    newList.Add(addList[i]);
                }
            }

            return newList;
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
