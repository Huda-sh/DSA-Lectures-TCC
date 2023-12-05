
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class Node
    {
        public int Data { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public Node(int val)
        {
            this.Data = val;
        }
    }
}
