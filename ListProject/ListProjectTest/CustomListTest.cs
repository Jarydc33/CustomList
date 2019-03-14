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
        public void Count_ReadOnly_IsReadOnly()
        {
            //Asign
            CustomList<int> list = new CustomList<int>();
            list.Add(5);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            int expected = 4;
            int actual;

            //Act
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

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
        public void Add_AddOneNewObject_AddedToIndexZero()
        {
            //Asign
            CustomList<Test> list = new CustomList<Test>();
            int expected = 10;
            int actual; 

            //Act
            list.Add(new Test(10, "Jaryd"));
            actual = list[0].score;

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Add_AddMultipleNewObjects_AddedToIndexZero()
        {
            //Asign
            CustomList<Test> list = new CustomList<Test>();
            string expected = "Mike";
            string actual;

            //Act
            list.Add(new Test(1,"Jaryd"));
            list.Add(new Test(2, "Not Jaryd"));
            list.Add(new Test(3, "Mike"));
            actual = list[2].name;

            //Assert
            Assert.AreEqual(expected, actual);
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
            // Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            //Act
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
        public void Remove_RemoveFirstObject_AllIndexesShiftOnce()
        {
            //Asign
            CustomList<Test> list = new CustomList<Test>();
            Test test = new Test(1,"Jaryd");
            list.Add(test);
            list.Add(new Test(2, "Not Jaryd"));
            list.Add(new Test(3, "Mike"));
            string expected = "Not Jaryd";
            string actual;

            //Act
            list.Remove(test);
            actual = list[0].name;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveSecondObject_AllIndexesShiftOnce()
        {
            //Asign
            CustomList<Test> list = new CustomList<Test>();
            Test test = new Test(1, "Jaryd");
            
            list.Add(new Test(2, "Not Jaryd"));
            list.Add(test);
            list.Add(new Test(3, "Mike"));
            string expected = "Mike";
            string actual;

            //Act
            list.Remove(test);
            actual = list[1].name;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveFifthObject_AllIndexesShiftOnce()
        {
            //Asign
            CustomList<Test> list = new CustomList<Test>();
            Test test = new Test(1, "Jaryd");

            list.Add(new Test(2, "Not Jaryd"));
            list.Add(new Test(3, "Mike"));
            list.Add(new Test(10, "HI"));
            list.Add(new Test(11, "NOHI"));
            list.Add(test);
            list.Add(new Test(12, "Bye"));
            list.Add(new Test(13, "Jim"));
            string expected = "Bye";
            string actual;

            //Act
            list.Remove(test);
            actual = list[4].name;

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

        [TestMethod]
        public void Remove_RemoveItemsNotNextToEachOther_IndexShiftsCorrectly()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(2);
            list.Add(2);
            int expected = 15;
            int actual;

            //Act
            list.Remove(2);
            list.Add(15);
            actual = list[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemNotInIndex_CountDoesntChange()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(2);
            list.Add(2);
            int expected = 5;
            int actual;

            //Act
            list.Remove(50);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemNotInIndex_IndexDoesntChange()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(8);
            list.Add(3);
            list.Add(9);
            list.Add(2);
            int expected = 2;
            int actual;

            //Act
            list.Remove(50);
            actual = list[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_StringifyUsingInts_OneLongStringOfInts()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            string expected = "12345";
            string actual;

            //Act
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_StringifyMultipleStrings_OneLongStringOfStrings()
        {
            //Assign
            CustomList<string> list = new CustomList<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("JARYD");
            string expected = "1234JARYD";
            string actual;

            //Act
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_OverloadPlusOperator_ConcatLists()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            int expected = 6;
            int actual;

            //Act
            result = list + list2;
            actual = result[5];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_OverloadPlusOperatorTwoTimes_ConcatLists()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            int expected = 6;
            int actual;
            list3 = list + list2;

            //Act
            result = list3 + list2;
            actual = result[8];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_OverloadMinusOperator_SubtractLists()
        {
            //Assign
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(1);
            list2.Add(6);
            int expected = 3;
            int actual;

            //Act
            result = list1 - list2;
            actual = result[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_OverloadMinusOperatorTwoTimes_SubtractLists()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list2.Add(2);
            list2.Add(1);
            list2.Add(6);
            int expected = 3;
            int actual;
            list3 = list - list2;
            list2.Add(5);

            //Act
            result = list3 - list2;
            actual = result[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Overload_AccessOutOfRangeAfterMinus_SubtractLists()
        {
            //Assign
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list2.Add(2);
            list2.Add(1);
            list2.Add(6);
            int expected = 3;
            int actual;
            list3 = list - list2;
            list2.Add(5);

            //Act
            result = list3 - list2;
            actual = result[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_TwoLists_AlternateAddingLists()
        {
            //Asign
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            int expected = 4;
            int actual;

            //Act
            result = CustomList<int>.Zip(list1, list2);

            //result = list1;
            actual = result[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_TwoListsUnequalLength_ListBleedoffToEnd()
        {
            //Asign
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            list2.Add(8);
            list2.Add(10);
            int expected = 10;
            int actual;

            //Act
            result = CustomList<int>.Zip(list1, list2);
            actual = result[7];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_TwoListsUnequalLengthOtherList_ListBleedoffToEnd()
        {
            //Asign
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(2);
            list1.Add(4);
            list2.Add(6);
            list2.Add(8);
            list2.Add(10);
            int expected = 4;
            int actual;

            //Act
            result = CustomList<int>.Zip(list1, list2);
            actual = result[7];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_TwoListsUnequalLengthString_ListBleedoffToEnd()
        {
            //Asign
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> result = new CustomList<string>();
            list1.Add("Jaryd");
            list1.Add("the");
            list1.Add("person");
            list1.Add("you");
            list1.Add("know");
            list2.Add("is");
            list2.Add("best");
            list2.Add("that");
            string expected = "know";
            string actual;

            //Act
            result = CustomList<string>.Zip(list1, list2);
            actual = result[7];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_SortListNumerically_IndexedCorrectly()
        {
            //Asign
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(2);
            list1.Add(4);
            list1.Add(8);
            list1.Add(6);
            list1.Add(10);
            int expected = 3;
            int actual;

            //Act
            list1.Sort();
            actual = list1[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_SortListWithTwoEqualNumbers_IndexedCorrectly()
        {
            //Asign
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(5);
            list1.Add(4);
            list1.Add(8);
            list1.Add(6);
            list1.Add(10);
            int expected = 4;
            int actual;

            //Act
            list1.Sort();
            actual = list1[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_SortListOtherThanInt_IndexedCorrectly()
        {
            //Asign
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> result = new CustomList<string>();
            list1.Add("X");
            list1.Add("J");
            list1.Add("Z");
            list1.Add("A");
            list1.Add("F");
            list1.Add("K");
            list1.Add("R");
            list1.Add("R");
            string expected = "Z";
            string actual;

            //Act
            list1.Sort();
            actual = list1[7];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_SortObject_ThrowException()
        {
            //Asign
            CustomList<Test> list1 = new CustomList<Test>();
            list1.Add(new Test(10, "Jaryd"));
            list1.Add(new Test(11, "Jaryd1"));

            //Act
            list1.Sort();
        }
    }
    //This class is here to test the functionality of adding and removing objects
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
