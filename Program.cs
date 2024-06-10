namespace Program
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
            //Console.WriteLine("싱글리스트 생성");
        }

        public int Size()
        {
            return size;
        }

        public void PushFront(T data)
        {
            if(head == null)
            {
                head= new Node();
                head.data= data;
                head.next = null;
            }
            else
            {
                Node newNode= new Node();
                newNode.data= data;
                newNode.next = head;
                head = newNode;
            }

            size++;
        }

        public void PushBack(T data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else
            {
                Node newNode = new Node();
                Node curNode = head;

                newNode.data = data;
                newNode.next = null;
                while (true)
                {
                    if (curNode.next == null)
                    {
                        curNode.next = newNode;
                        break;
                    }

                    else
                    {
                        curNode = curNode.next;
                    }
                }
            }
            size++;
        }

        public void PopBack()
        {
            if (head != null)
            {
                Node prevNode = head;
                Node curNode = head;
                while (true)
                {
                    if (curNode.next == null)
                    {
                        prevNode.next = null;
                        break;
                    }

                    else
                    {
                        prevNode = curNode;
                        curNode = curNode.next;
                    }
                }
                size--;    
            }
        }

        public void PopFront()
        {
            if (head != null)
            {
                head = head.next;
                size--;
            }
            
        }

        public void PrintAll()
        {
            if(head != null)
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
           SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();
            singleLinkedList.PushFront(1);
            singleLinkedList.PushFront(2);
            singleLinkedList.PushFront(3);

            singleLinkedList.PushBack(10);
            singleLinkedList.PushBack(20);
            singleLinkedList.PushBack(30);

            singleLinkedList.PrintAll();
            Console.WriteLine("\n SingleList Size : "+singleLinkedList.Size());
            Console.WriteLine("--------------------------------\n");
            
            singleLinkedList.PopBack();
            singleLinkedList.PopFront();
            singleLinkedList.PopFront(); 
            singleLinkedList.PrintAll();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("\n SingleList Size : " + singleLinkedList.Size());
        }
    }
}
