﻿using System;
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
        private int capacity;
        public int Capacity { get { return capacity; } }
        public string MyString;

        public CustomList()
        {
            items = new T[0];
            count = 0;
            capacity = 0;
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
            CapacityIncrementer();

            items[count] = item;
            count++;
        }

        private void CapacityIncrementer()
        {
            if (items.Length == count)
            {
                capacity += 4;
                CreateBiggerArray();
            }
        } 

        private void CreateBiggerArray()
        {
            T[] tempArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                tempArray[i] = items[i];
            }
            items = tempArray;
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
                    } while (j < count-1); //check this
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
            MyString = null;
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

        public static CustomList<T> operator -(CustomList<T> baseList, CustomList<T> subtractList)
        {
            CustomList<T> newList = new CustomList<T>();

            for(int i = 0; i < baseList.count; i++)
            {
                newList.Add(baseList[i]);
            }

            for (int i = 0; i < subtractList.count; i++)
            {
                newList.Remove(subtractList[i]);
            }
            return newList;
        }

        public static CustomList<T> Zip(CustomList<T> zipList, CustomList<T> zipList2)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < zipList.count && i < zipList2.count; i++)
            {
                newList.Add(zipList[i]);
                newList.Add(zipList2[i]);
                if(zipList.count != zipList2.count)
                {

                    zipList.ZipUnequalLists(zipList.count,i,zipList2,newList);
                    zipList2.ZipUnequalLists(zipList2.count,i,zipList,newList);
                }
            }

            return newList;
        }

        private void ZipUnequalLists(int countSize, int counter,CustomList<T> zippedList,CustomList<T> newList)
        {
            if (counter + 1 == countSize)
            {
                for (int j = counter + 1; j < zippedList.count; j++)
                {
                    newList.Add(zippedList[j]);
                }

            }
        }

        public void Sort() //Insertion Sort
        {
            var comparer = Comparer<T>.Default;
            CustomList<T> tempList = new CustomList<T>();
            tempList.Add(items[0]);
            int value;

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    value = comparer.Compare(items[j - 1], items[j]);
                    if (value > 0)
                    {
                        tempList[0] = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = tempList[0];
                    }
                }
            }
        }
    }        
}
