using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(30, tree.Root);
            tree.Add(20, tree.Root);
            tree.Add(10, tree.Root);
            tree.Add(25, tree.Root);
            tree.Add(40, tree.Root);
            tree.Add(35, tree.Root);
            tree.Add(45, tree.Root);

            tree.PrintPreOrder(tree.Root);
            Console.WriteLine();
            tree.PrintInOrder(tree.Root);
            Console.WriteLine();
            tree.PrintPostOrder(tree.Root);
            Console.WriteLine("==========================");
            Console.WriteLine(tree.GetMin(tree.Root));
            Console.WriteLine(tree.GetMax(tree.Root));
        }
    }
}
