namespace BinaryTrees
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public void Add(int val, Node node)
        {
            if (Root == null)
            {
                Root = new Node(val);
                return;

            }
            if (val < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(val);
                }
                else
                    Add(val, node.Left);
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(val);
                }
                else
                    Add(val, node.Right);
            }
        }
        public void PrintInOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PrintInOrder(node.Left);                // left
            System.Console.Write(node.Data + "\t"); // root
            PrintInOrder(node.Right);               // right
        }

        public void PrintPreOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            System.Console.Write(node.Data + "\t");    // root
            PrintPreOrder(node.Left);                // left
            PrintPreOrder(node.Right);               // right
        }
        public void PrintPostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PrintPostOrder(node.Left);                // left
            PrintPostOrder(node.Right);               // right
            System.Console.Write(node.Data+"\t");    // root
        }

        public int GetMin(Node node)
        {
            if (node == null)
            {
                return -1;
            }
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node.Data;
        }
        public int GetMax(Node node)
        {
            if (node == null)
            {
                return -1;
            }
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node.Data;
        }

    }


}
