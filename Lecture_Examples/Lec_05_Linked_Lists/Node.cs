using System;

namespace Lec_05_Linked_Lists
{
    public class Node
    {
        // properties
        public int Data { get; set; }
        public Node Next { get; set; }

        // constructors
        public Node() { }
        public Node(int val)
        {
            this.Data = val;
        }
    }
}
