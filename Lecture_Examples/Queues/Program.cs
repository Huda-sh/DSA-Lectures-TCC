using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Print();

            queue.Dequeue();
            queue.Print();
            queue.Dequeue();
            queue.Print();
            queue.Dequeue();
            queue.Print();
            queue.Dequeue();
            queue.Print();
        }
    }
}
