using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_07_Stacks
{
    class Stack<T>
    {
        public Node<T> Top { get; set; }
        public int Count { get; set; }

        public void Push(T val)
        {
            Node<T> new_element = new Node<T>(val);
            new_element.Next = Top;
            Top = new_element;
            Count++;
        }

        public T Pop()
        {
            if (Top == null)
            {
                return default;
            }
            T poped_value = Top.Data;
            Top = Top.Next;
            Count--;
            return poped_value;
        }

        public void Print()
        {
            Stack<T> stack = new Stack<T>();

            while (Top != null)
            {
                T v = Pop();
                Console.Write(v + "\t");
                stack.Push(v);
            }
            Console.WriteLine();

            while (stack.Top != null)
            {
                Push(stack.Pop());
            }
        }
    }
}
