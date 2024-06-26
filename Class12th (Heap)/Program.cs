namespace Class12th__Heap_
{
    public class Heap<T>
    {
        int arraySize;
        int size;

        int[] array;

        public Heap()
        {
            arraySize = 8;
            size = 0;
            array = new int[arraySize];
        }

        public void Swap(int child, int parent)
        {
            int temp = array[parent];
            array[parent] = array[child];
            array[child] = temp;
        }

        public void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        public void Insert(int data)
        {
            if (size + 1 >= arraySize)
            {
                Console.WriteLine("OverFlow");
            }

            else
            {
                array[++size] = data;

                int child = size;
                int parent = size / 2;

                while (child != 1)
                {
                    if (array[parent] < array[child])
                    {
                        Swap(child, parent);
                        child = parent;
                        parent = child / 2;
                    }

                    else
                        break;
                }
            }
        }

        public int Remove()
        {
            if (size <= 0)
            {
                Console.WriteLine("UnderFlow");
                return -1;
            }

            int result = array[1];
            array[1] = array[size];
            array[size--] = 0;

            int cur = 1;
            while (cur * 2 <= size)
            {
                int next;
                if (cur * 2 + 1 <= size)
                    next = array[cur * 2] > array[cur * 2 + 1] ? cur * 2 : cur * 2 + 1;
                else
                    next = cur * 2;


                if (array[next] > array[cur])
                    swap(ref array[cur], ref array[next]);

                cur = next;
            }


            return result;
        }

        public void Show()
        {
            int level = 1;
            int goal = 1;
            int num = 0;
            int padding = size / 2;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < padding; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(array[i] + " ");
                num++;

                if (num == goal)
                {
                    goal *= 2;
                    level++;
                    num = 0;
                    Console.WriteLine("\n");
                    padding /= 2;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           //Heap<int> heap = new Heap<int>();
           //heap.Insert(5);
           //heap.Insert(10);
           //heap.Insert(7);
           //heap.Insert(8);
           //heap.Insert(15);
           //
           //heap.Insert(9);
           //heap.Insert(1);
           //
           //
           //Console.WriteLine("REMOVE : " + heap.Remove());
           //
           //heap.Show();
        }
    }
}
