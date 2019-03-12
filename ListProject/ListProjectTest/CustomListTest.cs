using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListProject;

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


    }
}
