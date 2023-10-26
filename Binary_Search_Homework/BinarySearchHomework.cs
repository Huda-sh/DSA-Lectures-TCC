using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (start > end)
                return -1;
            //
            int third = (end - start) / 3;
            int firstMid = start + third;
            int secondMid = start + 2 * third;

            if (arr[firstMid] == key)
                return firstMid;
            else if (arr[secondMid] == key)
                return secondMid;
            else if (key < arr[firstMid])
                return TernarySearch(arr, key, start, firstMid - 1);
            else if (key > arr[secondMid])
                return TernarySearch(arr, key, secondMid + 1, end);
            else
                return TernarySearch(arr, key, firstMid + 1, secondMid - 1);
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            int result = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (key == arr[mid])
                {
                    result = mid;
                    if (is_first)
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
                else if (key < arr[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return result;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int firstOccurrence = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            if (firstOccurrence == -1)
                return 0; // element not present in array
            int lastOccurrence = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);
            return (lastOccurrence - firstOccurrence + 1);
        }
    }
}
