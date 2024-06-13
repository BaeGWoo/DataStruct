namespace Class1th__SingleLinkedList_
{
    public class SingleLinkedList<T>
    {
        private class Node
        {
            public T data;
            public Node next;

        }

        private int size;
        private Node head;


        public SingleLinkedList()
        {
            size = 0;
            head = null;
        }
        public int GetSize()
        {
            return size;
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

        public void PushBack(T data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
            }

            else
            {
                Node curNode = head;
                while (true)
                {
                    if (curNode.next != null)
                    {
                        curNode = curNode.next;
                    }

                    else
                    {
                        curNode.next = newNode;
                        break;
                    }
                }
            }
            size++;
        }

        public void PushFront(T data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
            }

            else
            {
                newNode.next = head;
                head = newNode;

            }
            size++;
        }

        public void RemoveBack()
        {
            if (head != null)
            {
                Node curNode = head;
                Node prevNode = curNode;
                while (true)
                {

                    if (curNode.next != null)
                    {
                        prevNode = curNode;
                        curNode = curNode.next;
                    }
                    else
                    {
                        if (curNode == head)
                        {
                            head = null;
                        }
                        prevNode.next = null;
                        break;
                    }
                }
                size--;
            }
        }

        public void RemoveFront()
        {
            if (head != null)
            {
                head = head.next;
                size--;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // SingleLinkedList<int> list = new SingleLinkedList<int>();
            // list.PushBack(10);
            // list.PushBack(20);
            // list.PushBack(30);
            //
            // Console.WriteLine("List Size : " + list.GetSize());
            // list.PrintAll();
            // Console.WriteLine();
            // list.RemoveBack();
            // list.RemoveFront();
            // Console.WriteLine("List Size : " + list.GetSize());
            // list.PrintAll();
            //
            // list.PushFront(1);
            // list.PushFront(2);
            // list.PushFront(3);
            //
            // Console.WriteLine("List Size : " + list.GetSize());
            // list.PrintAll();
        }
    }
}
