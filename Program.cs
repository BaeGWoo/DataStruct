namespace Program
{
    public class DoubleLinkedList<T>
    {
        private class Node
        {
            public T data;
            public Node next;
            public Node prev;
        }

        private int size;
        private Node head;
        private Node tail;


        public DoubleLinkedList()
        {
            size = 0;
            head = null;
            tail = null;
        }

        public void PushBack(T data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (tail == null)
            {             
                newNode.next = null;
                newNode.prev = null;

                tail = newNode;
                head = newNode;
            }

            else
            {
                newNode.prev = tail;
                newNode.next = null;
                tail.next = newNode;

                tail = newNode;
            }
        }

        public void PrintAll()
        {
            if (head != null)
            {
                Node curNode = head;
                while (true)
                {
                    Console.WriteLine(curNode.data);
                    curNode = curNode.next;

                    if (curNode == null)
                        break;
                }
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.PushBack(10);
            doubleLinkedList.PushBack(20);
            doubleLinkedList.PushBack(30);

            doubleLinkedList.PrintAll();
        }
    }
}
