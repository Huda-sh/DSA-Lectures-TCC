using System;

namespace Lec_05_Linked_Lists
{
    public class LinkedList
    {
        // properties
        public Node First { get; set; }
        public int Count { get; set; }

        // methods

        public void AddInOrder(int val)
        {
            Node new_node = new Node(val);
            if (First == null || First.Data > val)
            {
                new_node.Next = First;
                First = new_node;
            }
            else
            {
                Node move = First;
                while (move.Next != null && move.Next.Data < val)
                {
                    move = move.Next;
                }
                new_node.Next = move.Next;
                move.Next = new_node;
            }
            Count++;
        }

        public void BubbleSort()
        {
            if (First == null || First.Next == null)
            {
                Console.WriteLine("Nothing to sort!!!");
            }
            for (Node i = First; i.Next != null; i = i.Next)
            {
                for (Node j = First; j.Next != null; j = j.Next)
                {
                    if (j.Data > j.Next.Data)
                    {
                        int temp = j.Data;
                        j.Data = j.Next.Data;
                        j.Next.Data = temp;
                    }
                }
            }
        }

        public void Print()
        {
            if (First == null)
            {
                Console.WriteLine("Nothing to print, List is empty!!!");
            }
            Node Move = First;
            while (Move != null)
            {
                Console.Write(Move.Data + "\t");
                Move = Move.Next;
            }
            Console.WriteLine();
        }
    }
}
