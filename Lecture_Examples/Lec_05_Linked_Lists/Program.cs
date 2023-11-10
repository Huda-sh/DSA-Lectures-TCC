using System;

namespace Lec_05_Linked_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.First = new Node(23);
            list.First.Next = new Node(12);
            list.First.Next.Next = new Node(8);
            list.First.Next.Next.Next = new Node(2);
            Console.WriteLine("List before sorting");
            list.Print();

            Console.WriteLine("\nList after sorting");
            list.BubbleSort();

            list.Print();

            list.AddInOrder(1);
            list.AddInOrder(43);
            list.AddInOrder(78);
            list.AddInOrder(7);

            Console.WriteLine("\nlist after adding items in order");
            list.Print();
        }
    }
}
