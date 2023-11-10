using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_04_Generics
{
    public class LinearSearch<T>
    {
        public void Print(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public int IterativeLinearSearch(T[] arr, T key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }

        public int RecursiveLinearSearch(T[] arr, T key, int index)
        {
            if (arr[index].Equals(key))
                return index;
            if (index == arr.Length - 1)
                return -1;
            return RecursiveLinearSearch(arr, key, index + 1);
        }
    }
}
