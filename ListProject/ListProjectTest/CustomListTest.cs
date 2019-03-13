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

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_SetIndexTooHigh_OutOfRange()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            list[5] = 19;

        }

        [TestMethod]
        public void Indexer_SetAnIndex_IndexChangesCorrectly()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            int expected = 19;
            int actual;

            //Act
            list[0] = 19;
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

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

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_SetIndexBelowZero_OutOfRange_()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            //Act
            list[-1] = 19;
        }

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

        [TestMethod]
        public void Remove_RemoveItem_ReturnsTrue()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            bool expected = true;
            bool actual;

            //Act
            actual = list.Remove(1);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemoveItem_CounterDecrement()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int expected = 4;
            int actual;

            //Act
            list.Remove(1);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemoveSecondIndex_IndexShiftsLeft()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int expected = 3;
            int actual;

            //Act
            list.Remove(2);
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveSecondIndex_AllIndexesShiftsLeft()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int expected = 4;
            int actual;

            //Act
            list.Remove(2);
            actual = list[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemThenAddItem_AddMethodShouldActNormally()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int expected = 15;
            int actual;

            //Act
            list.Remove(2);
            list.Add(15);
            actual = list[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveTwoItems_IndexShiftsTwice()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(4);
            list.Add(5);
            int expected = 4;
            int actual;

            //Act
            list.Remove(2);
            list.Add(15);
            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void Remove_RemoveIndex_CapacityDecrement()
        //{
        //    //Assign
        //    CustomList<int> list = new CustomList<int>();
        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(3);
        //    list.Add(4);
        //    list.Add(5);
        //    int expected = 4;
        //    int actual;

        //    //Act
        //    list.Remove(3);
        //    actual = list.Capacity;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void Remove_CheckFourthIndexAfterCapacityDecrement_IndexFourIsNotNull()
        //{
        //    //Assign
        //    CustomList<int> list = new CustomList<int>();
        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(3);
        //    list.Add(4);
        //    list.Add(5);
        //    int expected = 5;
        //    int actual;

        //    //Act
        //    list.Remove(2);
        //    actual = list[3];

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

    }
}
