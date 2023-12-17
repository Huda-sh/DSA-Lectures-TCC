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
                Console.Write(move.Data);
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
            if (First==null)
               Fisrt=nNode;
            else
            {
                Node t=First;
                while(t.Next!=null)
                    t=t.Next;
                
                 t.Next=nNode;
            }
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            if(First==null)
                return;
            if(First.Data==key)
                First=First.Next;
            else
            {
                 Node temp = First;
                 while (temp.Next != null)
                 {
                     if (temp.Next.Data == key)
                     {
                         temp= temp.Next.Next;
                         return;
                     }
                     else
                     temp = temp.Next;
                 }
            }
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
             Node temp= First;
             while (temp.Next != null)
             {
                 temp= temp.Next;
             }
             temp.Next = other_list.First;
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
           Node previous = null;
           Node current = head;
           Node next = null;
           while (current != null)
           {
               next = curr.next;
               current.next = previous;
               previous = current;
               current = next;
           }
           First = previous;
        }
    }
}
