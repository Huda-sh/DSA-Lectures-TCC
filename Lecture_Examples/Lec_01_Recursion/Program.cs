using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lec_01_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:\t");
            int num = Convert.ToInt32(Console.ReadLine());

            Stopwatch iterative_timer = new Stopwatch();
            Stopwatch recursive_timer = new Stopwatch();

            iterative_timer.Start();
            int factorial_iterative = GetFactorialIterative(num);
            iterative_timer.Stop();
            
            recursive_timer.Start();
            int factorial_recusive = GetFactorialRecursive(num);
            recursive_timer.Stop();

            Console.WriteLine("Calculating the factorial using the iterative approach took: {0} ms",iterative_timer.Elapsed);
            Console.WriteLine("Calculating the factorial using the recursive approach took: {0} ms",recursive_timer.Elapsed);


        }

        static int GetFactorialIterative(int num)
        {
            int factorial = 1;
            for (int i = num; i >= 2; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        static int GetFactorialRecursive(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            return num * GetFactorialRecursive(num - 1);
        }
    }
}
