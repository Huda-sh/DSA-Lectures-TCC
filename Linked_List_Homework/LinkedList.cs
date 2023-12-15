using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {  private Node head;
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

        public void Add(int val)
        { Node newnode=new Node (val);
          if (head==null){
           head =new Node;}
           else{Node current =head ;
                while(current.next!=null){
                current =current. next;}
                current. next =new Node;
          }     
    
        }
        public void RemoveKey(int key)
        {
    
            if(head==null)
            {return;
            }
            if (head. data==key){
                head=head. next;
                return;
            }
            Node current =head;
            while (current.next!=null)
            {if (current.next.data==key){
                current.next =current.next.next;
                return;}
             current =current.next;
            } 
            
        }
        public void Merge(LinkedList other_list)
        {
            if (head==null)
            {head =other list.head;
             return;}
            Node current =head;
            while (current.next!=null)
            {current =current.next;
            }
            current. next =other list.head;
        }
        public void Reverse()
        {
         if (head==null || head.next==null)
         {return;
         }
         Node prev=null;
         Node current =head;
        Node nextnode=null;
            while (current!=null)
            {next Node =current.next;
             current.next =prev;
             prev=current;
             current =next Node;}
            head =prev;
        }
    }
}
