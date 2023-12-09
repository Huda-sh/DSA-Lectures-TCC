using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Linked_List_Homework;

namespace Linked_List_Homework_Test
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void TestAdd()
        {
            // arrange
            LinkedList list = new LinkedList();

            // act
            list.Add(10);
            list.Add(30);
            list.Add(20);
            list.Add(60);
            list.Add(40);


            // assert
            Assert.AreEqual(10, list.First.Data); 
            Assert.AreEqual(30, list.First.Next.Data);
            Assert.AreEqual(20, list.First.Next.Next.Data);
            Assert.AreEqual(60, list.First.Next.Next.Next.Data);
            Assert.AreEqual(40, list.First.Next.Next.Next.Next.Data);
        }

        [TestMethod]
        public void TestRemoveKey()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            int key = 20;

            // act
            list.RemoveKey(key);

            // assert
            Assert.AreEqual(10, list.First.Data); // check if the first node is still 10
            Assert.AreEqual(30, list.First.Next.Data); // check if the second node is now 30
            Assert.IsNull(list.First.Next.Next); // check if the third node is null
        }

        [TestMethod]
        public void TestMerge()
        {
            // arrange
            LinkedList list1 = new LinkedList();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            LinkedList list2 = new LinkedList();
            list2.Add(40);
            list2.Add(50);
            list2.Add(60);

            // act
            list1.Merge(list2);

            // assert
            Assert.AreEqual(10, list1.First.Data); // check if the first node of list1 is still 10
            Assert.AreEqual(20, list1.First.Next.Data); // check if the second node of list1 is still 20
            Assert.AreEqual(30, list1.First.Next.Next.Data); // check if the third node of list1 is still 30
            Assert.AreEqual(40, list1.First.Next.Next.Next.Data); // check if the fourth node of list1 is now 40
            Assert.AreEqual(50, list1.First.Next.Next.Next.Next.Data); // check if the fifth node of list1 is now 50
            Assert.AreEqual(60, list1.First.Next.Next.Next.Next.Next.Data); // check if the sixth node of list1 is now 60
            Assert.IsNull(list1.First.Next.Next.Next.Next.Next.Next); // check if the seventh node of list1 is null
        }

        [TestMethod]
        public void TestReverse()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // act
            list.Reverse();

            // assert
            Assert.AreEqual(30, list.First.Data); // check if the first node is now 30
            Assert.AreEqual(20, list.First.Next.Data); // check if the second node is now 20
            Assert.AreEqual(10, list.First.Next.Next.Data); // check if the third node is now 10
            Assert.IsNull(list.First.Next.Next.Next); // check if the fourth node is null
        }
    }
}
