namespace Class15th__Binary_Search_Tree_
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

        void Add(ref Node node, int data)
        {
            if (node == null)
            {
                node = CreateNode(data);
            }

            else
            {
                if (node.data < data)
                    Add(ref node.right, data);
                else if (node.data > data)
                    Add(ref node.left, data);
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


        int FindData(Node node)
        {
            int result = node.data;
            if (node.left == null)
            {
                result = node.data;
                node = null;
                return result;
            }
            else
                return FindData(node.left);

        }
        void RemoveNode(ref Node Parent, ref Node cur, int data)
        {
            if (cur == null)
            {
                Console.WriteLine("Data is not Exist");

            }

            else
            {
                if (cur.data < data)
                    RemoveNode(ref cur, ref cur.right, data);
                else if (cur.data > data)
                    RemoveNode(ref cur, ref cur.left, data);
                else
                {
                    if (cur.left != null && cur.right != null)
                    {
                        cur.data = FindData(cur.right);
                    }

                    else
                    {
                        if (cur.left != null)
                        {
                            cur = cur.left;
                        }

                        else if (cur.right != null)
                        {
                            cur = cur.right;
                        }

                        else
                        {
                            cur = null;
                        }
                    }
                }

            }
        }

        public void Remove(int data)
        {
            Node cur = root;
            Node parent = root;

            RemoveNode(ref parent, ref cur, data);
        }

        public void Remove2(int data)
        {
            Node cur = root;
            Node parent = root;

            while (cur != null)
            {
                if (cur.data > data)
                {
                    parent = cur;
                    cur = cur.left;
                }

                else if (cur.data < data)
                {
                    parent = cur;
                    cur = cur.right;
                }

                else
                {
                    if (cur.right == null && cur.left == null)
                    {
                        if (parent.data > data)
                            parent.left = null;
                        else
                            parent.right = null;
                    }

                    else
                    {
                        if (cur.right == null && cur.left != null)
                        {
                            if (parent.data > cur.data)
                                parent.left = cur.left;
                            else
                                parent.right = cur.left;
                            //cur = cur.left;
                        }

                        else if (cur.right != null && cur.left == null)
                        {
                            if (parent.data > cur.data)
                                parent.left = cur.right;
                            else
                                parent.right = cur.right;
                            //cur = cur.right;
                        }

                        else
                        {
                            Node tempParent = cur;
                            Node temp = cur.right;
                            while (temp.left != null)
                            {
                                tempParent = temp;
                                temp = temp.left;
                            }
                            cur.data = temp.data;
                            if (tempParent.data > temp.data)
                                tempParent.left = temp.right;
                            else
                                tempParent.right = temp.right;

                            //temp = null;
                        }
                    }
                    break;
                }
            }//while
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
            tree.Insert(22);
            tree.Insert(21);
            tree.Insert(5);
            tree.Insert(14);
            //tree.Insert(7);
            //tree.Insert(9);
            //tree.Insert(22);
            //tree.Insert(6);
            //tree.Insert(8);
            //tree.Insert(24);
            //tree.Insert(20);
            //tree.Insert(18);
            //tree.Insert(16);


            //tree.Remove(30);
            tree.Remove2(21);
            Console.WriteLine(tree.Find(11));
            tree.Show();
        }
    }
}
