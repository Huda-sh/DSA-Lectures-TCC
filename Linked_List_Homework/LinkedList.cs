using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
            Node newNode = new Node(val);
            if (First == null)
                First = newNode;
            else
            {
             Node currentPointer = First;
                while (currentPointer.Next != null)
                {
                    currentPointer = currentPointer.Next;
                }
                currentPointer.Next = newNode; 
            }
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            if (First == null)
            {
                Console.WriteLine("Ooops! Linked List Is Empty \n");
                return;
            }
            if (First.Data == key)
            {
                First = First.Next;
            }
            else
            {
                Node curr = First;
            
                while (curr != null)
                {
                    while (curr.Next != null && curr.Next.Data == key)
                    {
                        curr.Next = curr.Next.Next;
                    }
                    if (curr != null)
                    {
                        curr = curr.Next;
                    }
                }
            }
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
             if(other_list.First==null)
             {
                 Console.WriteLine("\nOoops! The Other_List Is Empty!\n");
                 return;
             }
            
             if(First==null)
             {
                 First = other_list.First;
                 Console.WriteLine("\nAdded the other_list successfully in the beginning\n");
                 return;
             }
            
            Node curr= First;
             while (curr.Next != null)
             {
                 curr= curr.Next;
             }
             curr.Next = other_list.First;
             Console.WriteLine("\nAdded the other_list successfully in the end\n");
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
            Node prevPointer = null;
            Node currentPointer = First;
            Node nextPointer = null;
            while (currentPointer != null)
            {
                nextPointer = currentPointer.Next;
                currentPointer.Next = prevPointer;
                prevPointer = currentPointer;
                currentPointer = nextPointer;
            }
            First = prevPointer;
        }
    }
}
