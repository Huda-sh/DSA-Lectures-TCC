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
            int start = 0;
            int end = arr.Length - 1;
            
            while (start <= end)
            {
                int mid1 = (start + end) / 3;
                int mid2 = (2 * start + end) / 3;
                if (arr[mid1] == key)
                {
                    return mid1;
                }
                else if (arr[mid2] == key)
                {
                    return mid2;
                }
                else if (key < arr[mid1])
                {
                    end = mid1 - 1;
                }
                else if (key > arr[mid2])
                {
                    start = mid2 + 1;
                }
                else
                {
                    start = mid1 + 1;
                    end = mid2 - 1;
                }
            }
            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            start = 0;
            end = arr.Length - 1;
        
           while (start <= end)
           {
               int mid = start + (end - start) / 2;
        
               if (arr[mid] == key)
               {
                   if (is_first)
                   {
                       if (mid == 0 || arr[mid - 1] != key)
                          return mid;
                       else
                          end = mid - 1;
                   }
                   else
                   {
                       if (mid == arr.Length - 1 || arr[mid + 1] != key)
                          return mid;
                       else
                          start = mid + 1;
                   }
               }
               else if (arr[mid] < key)
               {
                   start = mid + 1;
               }
               else
               {
                   end = mid - 1;
               }
           }
        
           return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
             int first = BinarySearchForCalculatingRepeated(arr, key, true,0,0);
             int last = BinarySearchForCalculatingRepeated(arr, key, false,0,0);
        }
    }
}
