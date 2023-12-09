using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class Queue
    {
        public int Elements_Count { get; set; }
        public Node Front { get; set; }
        public Node Back { get; set; }

        public void Enqueue(int val)
        {
            Node new_node = new Node(val);
            if (Front == null)
            {
                Front = new_node;
                Back = new_node;
                Elements_Count++;
                return;
            }
            Back.Next = new_node;
            Back = new_node;
            Elements_Count++;
        }

        public int Dequeue()
        {
            if (Front == null)
            {
                return -1;
            }
            int temp = Front.Data;
            Front = Front.Next;
            Elements_Count--;
            return temp;
        }

        public void Print()
        {
            Node move = Front;
            while(move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }
    }
}
