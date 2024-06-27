namespace Program
{
    public class BinarySearchTree<T>
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

           
        }

        Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        Node CreateNode(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.left = null;
            newNode.right = null;
            return newNode;
        }

        void Add(ref Node node,int data)
        {
            if (node == null)
            {
                node= CreateNode(data);
            }

            else
            {
                if(node.data<data)
                    Add(ref node.right,data);
                else if(node.data>data)
                    Add(ref node.left,data);
            }
        }

        public void Insert(int data)
        {
            Node cur = root;
            Add(ref root, data);
        }


        bool Search(ref Node node, int data)
        {
            if (node == null)
                return false;
            else
            {
                if (node.data < data)
                    return Search(ref node.right, data);
                else if (node.data > data)
                    return Search(ref node.left, data);
                else
                    return true;
            }
        }

        public bool Find(int data)
        {
            Node cur = root;
            //while (cur != null)
            //{
            //    if (cur.data == data)
            //        return true;
            //
            //    if (cur.data < data)
            //    {
            //        cur = cur.right;
            //    }
            //
            //    else
            //        cur = cur.left;
            //}
            //return false;
            return Search(ref cur, data);
        }

        public void Show()
        {
            Node cur = root;
            InOrder(cur);
        }


        void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.Write(root.data + " ");
                InOrder(root.right);
            }
        }

       
    }

    internal class Program
    {
       

        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Insert(10);
            tree.Insert(12);
            tree.Insert(7);
            tree.Insert(5);
            tree.Insert(9);

            Console.WriteLine(tree.Find(11));
            tree.Show();
        }
    }
}
