using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_03_Binary_Search
{
    internal class Search
    {
        public static int Linear_Iterative(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int Linear_Recursive(int[] arr, int key, int i = 0)
        {
            if (arr.Length == i)
            {
                return -1;
            }
            if (arr[i] == key)
            {
                return i;
            }
            return Linear_Recursive(arr, key, i + 1);
        }

        public static int Binary_Recursive(int[] arr, int key, int start, int end)
        {
            int mid = (start + end) / 2;

            if (arr[mid] == key)
            {
                return mid;
            }
            if (start > end)
            {
                return -1;
            }
            if (arr[mid] > key)
            {
                return Binary_Recursive(arr, key, start, mid - 1);
            }
            return Binary_Recursive(arr, key, mid + 1, end);
        }

        public static int Binary_Iterative(int[] arr, int key)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] > key)
                {
                    end = mid - 1;
                }
                if (arr[mid] < key)
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
