using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            this.Data = val;
        }
    }
}
