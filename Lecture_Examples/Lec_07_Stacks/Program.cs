using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_07_Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Print();
            stack.Push(2);
            stack.Print();
            stack.Push(3);
            stack.Print();
            stack.Push(4);
            stack.Print();

            Console.WriteLine("=============");

            Console.WriteLine("poped value:\t" + stack.Pop());
            stack.Print();
            Console.WriteLine("poped value:\t" + stack.Pop());
            stack.Print();
            Console.WriteLine("poped value:\t" + stack.Pop());
            stack.Print();
            Console.WriteLine("poped value:\t" + stack.Pop());
            stack.Print();
            Console.WriteLine("poped value:\t" + stack.Pop());
            stack.Print();
        }
    }
}
