namespace Program
{
    public class HashTable<Key, Value>
    {
        private readonly int arraySize;
        private Bucket[] bucket;

        public class Node
        {
            public Key key;
            public Value value;

            public Node next;

            public Node(Key key,Value value)
            {
                this.key = key;
                this.value = value;
                next = null;
            }
        }

       public class Bucket
        {
            public int count;
            public Node head;

            public Bucket()
            {
                count = 0;
                head = null;
            }
        }

        public  HashTable()
        {
            arraySize = 6;
            bucket=new Bucket[arraySize];
            for(int i = 0; i < arraySize; i++)
            {
                Bucket newBucket= new Bucket();
                bucket[i] = newBucket;
            }
        }

        private int HashFunction(Key key)
        {
            int result=0;
            result = int.Parse(key.ToString()) % arraySize;
            return result;
        }

        private Node CreateNode(Key key, Value value)
        {
            Node newNode=new Node(key,value);
            return newNode;
        }

        public void Insert(Key key, Value value)
        {
            int index = HashFunction(key);
            Node newNode = CreateNode(key, value);

            if (bucket[index].head==null)
            {
                bucket[index].head = newNode;
            }

            else
            {
                Node curNode= bucket[index].head;
                //while(curNode.next != null)
                //{
                //    curNode=curNode.next;
                //}
                //curNode.next = newNode;
                newNode.next = curNode;
                bucket[index].head = newNode;
            }
            bucket[index].count++;
        }




        public void Show()
        {
            for (int i = 0; i < arraySize; i++)
            {
                Node curNode = bucket[i].head;
                Console.Write("[ " + i + " ] : ");
                for (int j = 0; j < bucket[i].count; j++)
                {
                    Console.Write(curNode.value + " ");
                    curNode = curNode.next;
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            HashTable<int, string> hash = new HashTable<int, string>();
            hash.Insert(10, "A"); //[4] A
            hash.Insert(10, "B"); //[4] B A 
            hash.Insert(10, "C"); //[4] C B A

            hash.Insert(0, "a");  //[0] a
            hash.Insert(0, "b");  //[0] b a
            hash.Insert(0, "c");  //[0] c b a

            hash.Show();


        }
    }
}
