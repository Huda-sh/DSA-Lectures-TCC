using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Binary_Search_Homework
{
    internal class Program
    {
        static void Main(string[] args) // feel free to edit the main method as you like
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int key = 10;

            // int idx = BinarySearchHomework.TernarySearch(arr1, key);
            int idx = BinarySearchHomework.TernarySearch(arr1, key, 0, arr1.Length);

            Console.WriteLine("Found {0} at index {1} using Ternary Search", key, idx);

            Console.WriteLine("=======================");

            int[] arr2 = { 1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 7, 8, 9 };
            int key2 = 5;

            int repeat_count = BinarySearchHomework.GetRepeatCount(arr2, key2);

            Console.WriteLine("the number 2 is repeated {0} times", repeat_count);
        }
    }
}
