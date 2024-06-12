namespace Program
{
    public class DoubleLinkedList<T>
    {
        public class Node
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

        public int GetSize()
        {
            return size;
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
            size++;
        }

        public void PushFront(T data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                newNode.next = null;
                newNode.prev = null;

                tail = newNode;
                head = newNode;
            }

            else
            {
                newNode.prev = null;
                newNode.next = head;
                head.prev = newNode;

                head = newNode;
            }
            size++;
        }

        public void RemoveBack()
        {
            if (tail != null)
            {
                if (head == tail)
                {
                    tail = null;
                    head = null;
                }

                else
                {
                    tail.prev.next = null;
                    tail = tail.prev;
                }
                size--;
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
        }

        public void RemoveFront()
        {
            if (head != null)
            {
                if (head == tail)
                {
                    tail = null;
                    head = null;
                }

                else
                {
                    head.next.prev = null;
                    head = head.next;
                }
                size--;
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
        }

        public void Insert(int num,T data)
        {
            if (size > num)
            {
                Node newNode = new Node();
                newNode.data = data;

                Node curNode= head;
                Node prevNode = curNode;

               if (num == 0)
                {
                    PushFront(data);
                }

                else
                {
                    for(int i = 0; i < num; i++)
                    {
                        prevNode = curNode;
                        curNode= curNode.next;
                    }

                    prevNode.next = newNode;
                    curNode.prev = newNode;

                    newNode.next = curNode;
                    newNode.prev = prevNode;
                    size++;
                }
            }

            else if (size == num)
            {
                PushBack(data);               
            }
        }

        public void Erase(int num)
        {
            if (num < size)
            {
                if (num == 0)
                {
                    RemoveFront();
                }

                else if (num == size - 1)
                {
                    RemoveBack();
                }

                else
                {
                    Node curNode = head;
                    Node prevNode = curNode;
                    for(int i = 0; i < num; i++)
                    {
                        prevNode = curNode;
                        curNode= curNode.next;
                    }
                    prevNode.next = curNode.next;
                    curNode.next.prev = prevNode;
                    size--;
                }
            }

           
        }

        public Node First()
        {
            return head;
        }

        public Node Last()
        {
            return tail;
        }

        public void AddAfter(Node position,T data)
        {
            if(position==null)
            {
                Console.WriteLine("Out of Range");
                return;
            }    
            if (position==tail)
            {
                PushBack(data);
            }

            else
            {
                Node next= position.next;
                Node newNode = new Node();
                newNode.data = data;

                position.next = newNode;
                next.prev = newNode;

                newNode.prev = position;
                newNode.next = next;
                size++;
            }
        }

        public void AddBefor(Node position, T data)
        {
            if (position == null)
            {
                Console.WriteLine("Out of Range");
                return;
            }
            if (position == head)
            {
                PushFront(data);
            }

            else
            {
                Node prev = position.prev;
                Node newNode = new Node();
                newNode.data = data;

                position.prev = newNode;
                prev.next = newNode;

                newNode.prev = prev;
                newNode.next = position;
                size++;
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
           //DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
           //doubleLinkedList.PushBack(10); //10
           //doubleLinkedList.PushBack(20); //10 20
           //doubleLinkedList.PushBack(30); //10 20 30
           //
           //doubleLinkedList.PrintAll();
           //Console.WriteLine("List Size : "+doubleLinkedList.GetSize() + "\n");
           //Console.WriteLine();
           //
           //doubleLinkedList.Insert(3, 99); //10 20 30 99
           //doubleLinkedList.Insert(1, 100); // 10 100 20 30 99
           //doubleLinkedList.Insert(0, 333); // 333 10 100 20 30 99
           //doubleLinkedList.Erase(2); //333 10 20 30 99
           ////doubleLinkedList.Erase(0); // 100 30 99 
           ////doubleLinkedList.RemoveBack(); // 10 100 30 
           //
           //doubleLinkedList.PrintAll();
           //Console.WriteLine("List Size : " + doubleLinkedList.GetSize() + "\n");
           //Console.WriteLine();
           //
           //doubleLinkedList.Insert(0, 999); // 999 10 100 20 30 99
           //doubleLinkedList.PrintAll();
           //Console.WriteLine("List Size : " + doubleLinkedList.GetSize()+"\n");
           
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.PushBack(10);
            doubleLinkedList.PushBack(20);
            doubleLinkedList.PushBack(30);

            DoubleLinkedList<int>.Node first = doubleLinkedList.First();
            DoubleLinkedList<int>.Node last = doubleLinkedList.Last();
            doubleLinkedList.AddAfter(first, 99); // 10 99 20 30
            doubleLinkedList.AddAfter(last, 333); // 10 99 20 30 333
            doubleLinkedList.PrintAll();

            Console.WriteLine();
            //last=doubleLinkedList.Last();

            doubleLinkedList.AddBefor(first, 100); //100 10 99 20 30
            doubleLinkedList.AddBefor(last, 77); // 100 10 99 20 77 30 333
            doubleLinkedList.PrintAll();

        }
    }
}
