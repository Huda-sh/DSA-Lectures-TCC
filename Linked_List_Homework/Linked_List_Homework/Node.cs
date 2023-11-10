using System;

namespace Linked_List_Homework
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Data = val;
        }
    }
}
