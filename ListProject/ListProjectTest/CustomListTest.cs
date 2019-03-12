using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListProject;
using System.IO;

namespace ListProjectTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_EmptyArray_AddedToIndexZero()
        {
            //Asign
            CustomList<int> list = new CustomList<int>();
            int addItem = 10;
            int expected = 10;
            int actual;

            //Act
            list.Add(addItem);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Add_CheckFirstElementAfterCapacityIncrement_FirstElementCorrect()
        {
            //Asign
            CustomList<int> list = new CustomList<int>();
            list.Add(5);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            int addItem = 1;
            int expected = 5;
            int actual;

            //Act
            list.Add(addItem);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_EmptyArray_CountIncrement()
        {
            //Asign
            CustomList<int> list = new CustomList<int>();
            int addItem = 1;
            int expected = 1;
            int actual;

            //Act
            list.Add(addItem);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingFirstItem_CapacityIncrement()
        {
            //Asign
            CustomList<int> list = new CustomList<int>();
            int addItem = 1;
            int expected = 4;
            int actual;

            //Act
            list.Add(addItem);
            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingFifthItem_CapacityIncrement()
        {
            //Asign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            int addItem = 1;
            int expected = 8;
            int actual;

            //Act
            list.Add(addItem);
            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingSixthItem_AddedToIndexFive()
        {
            //Asign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            int addItem = 10;
            int expected = 10;
            int actual;

            //Act
            list.Add(addItem);
            actual = list[5];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void Indexer_SetIndexTooHigh_OutOfRange()
        //{
        //    CustomList<int> list = new CustomList<int>();
        //    list.Add(1);
        //    list.Add(1);
        //    list.Add(1);
        //    list.Add(1);
        //    list.Add(1);
        //    list[5] = 19;

        //}

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_GetIndexTooHigh_OutOfRange()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            //Act
            Console.WriteLine(list[5]);

        }

        //[TestMethod]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        //public void Indexer_SetIndexBelowZero_OutOfRange_()
        //{
        //    //Assign
        //    CustomList<int> list = new CustomList<int>();
        //    list.Add(1);
        //    list.Add(1);
        //    list.Add(1);
        //    list.Add(1);
        //    list.Add(1);

        //    //Act
        //    list[-1] = 19;
        //}

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_GetIndexBelowZero_OutOfRange_()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            //Act
            Console.WriteLine(list[-1]);
        }

        [TestMethod]
        public void Indexer_GetArrayByIndex_AllowAccess_()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(4);
            list.Add(8);
            list.Add(16);
            int actual;
            int expected = 1;

            //Act
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
