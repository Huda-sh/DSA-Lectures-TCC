using System;

namespace Linked_List_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("Adding nodes ...");
            list.Add(1); 
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Print();

            Console.WriteLine("\n reversing list ...");
            list.Reverse();
            list.Print();

            Console.WriteLine("\nRemoving node ...");
            list.RemoveKey(4);
            list.Print();

            Console.WriteLine("\nCreating list 2"); 
            LinkedList list2 = new LinkedList();
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);
            list2.Add(10);
            list2.Print();

            Console.WriteLine("\nMerging the lists");
            list.Merge(list2);
            list.Print();
        }
    }
}
