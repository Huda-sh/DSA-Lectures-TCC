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
        {int  []array;
         array =arr;
         int n=array.length;
         int third =n/3;
         int[] firstpart =new int [third];
         int[] secondpart =new int [third];
         int[] thirdpart =new int [n-2*third];
         for (int i=0;i<third;i++){
             firstpart[i]=array [i];}
         for (int i=0;i<third;i++){
             secondpart[i]=array [i+third];}
         for (int i=0;i<n-2*third;i++){
             thirdpart[i]=array [i+2*third];}
            //TODO: write code for the ternary search algorithm and return the index of the element
            return -1;
        }return firstpart ;

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            return -1;
        }return secondpart;

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            return -1;
        }return thirdpart;
    }
}
