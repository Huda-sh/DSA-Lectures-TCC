using System;
using System.Diagnostics;


namespace Lec_02_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArraySort arraySort = new ArraySort(10);
            arraySort.RandomFill();
            //arraySort.Print();
            //Console.WriteLine("======================");
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("sorting 10 items ...");
            stopwatch.Start();
            arraySort.SelectionSortIterative();
            stopwatch.Stop();
            Console.WriteLine("sorted in {0} ms", stopwatch.Elapsed);
            stopwatch.Reset();

            arraySort = new ArraySort(100);
            arraySort.RandomFill();
            //arraySort.Print();
            Console.WriteLine("======================");
            Console.WriteLine("sorting 100 items ...");
            stopwatch.Start();
            arraySort.SelectionSortIterative();
            stopwatch.Stop();
            Console.WriteLine("sorted in {0} ms", stopwatch.Elapsed);
            stopwatch.Reset();

            arraySort = new ArraySort(1000);
            arraySort.RandomFill();
            //arraySort.Print();
            Console.WriteLine("======================");
            Console.WriteLine("sorting 1000 items ...");
            stopwatch.Start();
            arraySort.SelectionSortIterative();
            stopwatch.Stop();
            Console.WriteLine("sorted in {0} ms", stopwatch.Elapsed);
            stopwatch.Reset();

            arraySort = new ArraySort(10000);
            arraySort.RandomFill();
            //arraySort.Print();
            Console.WriteLine("======================");
            Console.WriteLine("sorting 10000 items ...");
            stopwatch.Start();
            arraySort.SelectionSortIterative();
            stopwatch.Stop();
            Console.WriteLine("sorted in {0} ms", stopwatch.Elapsed);
            stopwatch.Reset();

            arraySort = new ArraySort(100000);
            arraySort.RandomFill();
            //arraySort.Print();
            Console.WriteLine("======================");
            Console.WriteLine("sorting 100000 items ...");
            stopwatch.Start();
            arraySort.SelectionSortIterative();
            stopwatch.Stop();
            Console.WriteLine("sorted in {0} ms", stopwatch.Elapsed);
            stopwatch.Reset();
            //arraySort.Print();
        }
    }
}
