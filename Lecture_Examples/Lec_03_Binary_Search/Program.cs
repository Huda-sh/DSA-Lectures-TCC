using System;
using System.Diagnostics;

namespace Lec_03_Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            Console.WriteLine("Enter search key:");
            int key = Convert.ToInt32(Console.ReadLine());
            Stopwatch sw = new Stopwatch();
            int res = -1;

            Console.WriteLine("=====================================");
            Console.WriteLine("Searching in iterative linear ...\n");
            sw.Start();
            res = Search.Linear_Iterative(arr, key);
            sw.Stop();
            Console.WriteLine("key found at {0} index, time took {1} ms",res ,sw.Elapsed);
            sw.Reset();
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Searching in recursive linear ...");
            sw.Start();
            res = Search.Linear_Recursive(arr, key);
            sw.Stop();
            Console.WriteLine("key found at {0} index, time took {1} ms", res, sw.Elapsed);
            sw.Reset();
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Searching in iterative binary ...");
            sw.Start();
            res = Search.Binary_Iterative(arr, key);
            sw.Stop();
            Console.WriteLine("key found at {0} index, time took {1} ms", res, sw.Elapsed);
            sw.Reset();
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Searching in recursive binary ...");
            sw.Start();
            res = Search.Binary_Recursive(arr, key, 0, arr.Length - 1);
            sw.Stop();
            Console.WriteLine("key found at {0} index, time took {1} ms", res, sw.Elapsed);
            sw.Reset();

            Console.WriteLine();
        }
    }
}
