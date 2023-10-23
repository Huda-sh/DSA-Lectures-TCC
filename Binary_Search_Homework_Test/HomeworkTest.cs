using Binary_Search_Homework;// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
using Microsoft.VisualStudio.TestTools.UnitTesting;// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
namespace Binary_Search_Homework_Test// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
{
    [TestClass]// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
    public class HomeworkTest // DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
    {
        [TestMethod]// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
        public void TestTernarySearch()// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int key = 10;

            int index = BinarySearchHomework.TernarySearch(arr, key, 0, arr.Length);

            Assert.AreEqual(9, index);
        }// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!

        [TestMethod]// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
        public void TestGetFirstElement()// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
        {
            int[] arr = { 1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 7, 8, 9 };
            int key = 5;

            // pass true for the first occurrence
            int first = BinarySearchHomework.BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length);
            Assert.AreEqual(6, first);
        }// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
        [TestMethod]// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
        public void TestGetLastElement()// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
        {
            int[] arr = { 1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 7, 8, 9 };
            int key = 5;

            // pass true for the first occurrence
            int last = BinarySearchHomework.BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length);
            Assert.AreEqual(10, last);
        }// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!

        [TestMethod]// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
        public void TestGetRepeatCount()// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!
        {
            int[] arr = { 1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 7, 8, 9 };
            int key = 5;

            // pass true for the first occurrence
            int count = BinarySearchHomework.GetRepeatCount(arr, key);
            Assert.AreEqual(5, count);
        }// DON'T EDIT THIS FILE UNDER ANY CIRCUMSTANCES!!


    }
}
