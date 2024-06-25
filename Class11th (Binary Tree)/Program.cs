namespace Class11th__Binary_Tree_
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;


        public Node(int data)
        {
            this.data = data;
        }
    }


    internal class Program
    {

        static public Node CreateNode(int data, Node left, Node right)
        {
            Node newNode = new Node(data);

            newNode.left = left;
            newNode.right = right;

            return newNode;
        }

        static public void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                Preorder(root.left);
                Preorder(root.right);

            }
        }

        static void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.Write(root.data + " ");
                InOrder(root.right);
            }
        }

        static void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.Write(root.data + " ");
            }
        }
        static void Main(string[] args)
        {
           //Node node4 = CreateNode(4, null, null);
           //Node node5 = CreateNode(5, null, null);
           //Node node6 = CreateNode(6, null, null);
           //Node node7 = CreateNode(7, null, null);
           //
           //Node node2 = CreateNode(2, node4, node5);
           //Node node3 = CreateNode(3, node6, node7);
           //
           //Node node1 = CreateNode(1, node2, node3);
           //
           //PostOrder(node1);
        }
    }
}
