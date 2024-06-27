namespace Class14th__Graph_Adjacency_List_
{
    public class AdjacencyList<T>
    {
        public class Node
        {
            public T data;
            public Node next;

            public Node(T data)
            {
                this.data = data;
                next = null;
            }
        }

        int size;
        int arraySize;
        T[] vertex;
        Node[] list;

        public AdjacencyList()
        {
            size = 0;
            arraySize = 10;
            vertex = new T[arraySize];
            list = new Node[arraySize];
        }

        public void Insert(T data)
        {
            if (size < arraySize)
            {
                vertex[size] = data;
                list[size++] = new Node(data);
            }

            else
            {
                Console.WriteLine("List is Full");
            }
        }

        public void ConnectNode(int i, int j)
        {
            Node cur = list[i];
            while (cur.next != null)
            {
                cur = cur.next;
            }
            cur.next = new Node(vertex[j]);
        }


        public void Connect(int i, int j)
        {
            if (i < 0 || j < 0 || i >= size || j >= size)
            {
                Console.WriteLine("Out of Range");
                return;
            }


            ConnectNode(i, j);
            ConnectNode(j, i);
        }


        public void Show()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("[" + vertex[i] + "] ");
                Node cur = list[i].next;
                while (cur != null)
                {
                    Console.Write("=> ");
                    Console.Write("(" + cur.data + ") ");
                    cur = cur.next;
                }
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인접 리스트
            // 그래프의 각 정점에 인접한 정점들을 연결리스트로 
            // 표현하는 방법입니다.

            // 장점
            // 그래프의 모든 간선의 수를 O(V+E)로 표현할 수 있습니다.

            // 단점
            // 두 정점을 연결하는 간선을 조회하거나 정점의 차수를 알기 위해
            // 정점의 인접 리스트를 모두 탐색해야 하므로,
            // 정점의 차수만큼의 시간이 필요합니다.
           // AdjacencyList<char> list = new AdjacencyList<char>();
           // list.Insert('A');
           // list.Insert('B');
           // list.Insert('C');
           // list.Insert('D');
           //
           // list.Connect(0, 1);
           // list.Connect(0, 2);
           // list.Connect(2, 3);
           //
           //
           // list.Show();
            #endregion
        }
    }
}
