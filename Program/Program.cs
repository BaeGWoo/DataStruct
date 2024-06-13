namespace Program
{
    public class CircleLinkedList<T>
    {
        public class Node
        {
            public T data;
            public Node next;
        }
        int size;
        Node head; //tail의 기능을 수행

        public CircleLinkedList() {
            size = 0;
            head = null;
        }

        public void PushBack(T data)
        {
            Node newNode=new Node();
            newNode.data = data;

            if (head == null)
            {
                head = newNode;
                newNode.next = head;
            }

            else
            {
                newNode.next = head.next;
                head.next = newNode;
                head = newNode;
            }
            size++;
        }

        public void PushFront(T data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                head = newNode;
                newNode.next = head;
            }

            else
            {
                newNode.next = head.next;
                head.next = newNode;               
            }
            size++;
        }

        public void PrintAll()
        {
            if (head != null)
            {
                Node cur = head.next;
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(cur.data);
                    cur = cur.next;
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("List is Empty");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           CircleLinkedList<int> circleLinkedList = new CircleLinkedList<int>();
            circleLinkedList.PushBack(10);   // 10
            circleLinkedList.PushBack(20);   // 10 20
            circleLinkedList.PushBack(30);   // 10 20 30
            circleLinkedList.PrintAll();

            circleLinkedList.PushFront(99);  // 99 10 20 30
            circleLinkedList.PushFront(999); // 999 99 10 20 30 
            circleLinkedList.PrintAll();
        }
    }
}
