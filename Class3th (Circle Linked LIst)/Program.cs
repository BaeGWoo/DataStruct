namespace Class3th__Circle_Linked_LIst_
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

        public CircleLinkedList()
        {
            size = 0;
            head = null;
        }

        public void PushBack(T data)
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

        public void RemoveFront()
        {
            Node cur = head;
            if (cur != null)
            {
                if (head == head.next)
                {
                    head = null;
                }

                else
                {
                    head.next = head.next.next;
                }

                size--;
            }

            else
            {
                Console.WriteLine("List is Empty");
            }
        }

        public void RemoveBack()
        {
            Node cur = head;
            if (cur != null)
            {
                if (head == head.next)
                {
                    head = null;
                }
                else
                {
                    while (cur.next != head)
                    {
                        cur = cur.next;
                    }
                    cur.next = head.next;
                    head = cur;
                }
                size--;
            }

            else
            {
                Console.WriteLine("List is Empty");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           //CircleLinkedList<int> circleLinkedList = new CircleLinkedList<int>();
           //circleLinkedList.PushBack(10);   // 10
           //circleLinkedList.PushBack(20);   // 10 20
           //circleLinkedList.PushBack(30);   // 10 20 30
           //circleLinkedList.RemoveFront();  // 20 30
           //
           //circleLinkedList.PrintAll();
           //
           //circleLinkedList.PushFront(99);  // 99 20 30
           //circleLinkedList.PushFront(333); // 333 99 20 30 
           //circleLinkedList.RemoveBack();   // 333 99 20
           //
           //circleLinkedList.PrintAll();
        }
    }
}
