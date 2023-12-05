using System;

namespace Lec_06_Training_Forum_Example
{
    public class Node
    {
        public Member Data { get; set; }
        public Node Next { get; set; }
        public Node()
        {
        }
        public Node(Member data)
        {
            this.Data = data;
        }
    }
}
