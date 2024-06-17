namespace Class5th__Linear_Queue_
{
    public class LinearQueue<T>
    {
        private int count;
        private int front;
        private int rear;
        private int arraySize;
        private T error;
        private T[] arr;

        public LinearQueue()
        {
            count = 0;
            front = 0;
            rear = 0;
            arraySize = 5;
            arr = new T[arraySize];
        }

        public int Count()
        {
            return count;
        }

        public void Enqueue(T data)
        {
            if (rear < arr.Length)
            {
                arr[count++] = data;
                rear++;
            }
            else
            {
                Console.WriteLine("Queue is Full");
            }
        }

        public T Dequeue()
        {
            if (front != rear)
            {
                T result = arr[front];
                arr[front] = error;
                front++;
                count--;
                return result;
            }
            else
            {
                Console.WriteLine("Queue is Empty");
                return error;
            }
        }
        public T Peek()
        {
            if (front != rear)
            {
                return arr[front];
            }

            else
            {
                Console.WriteLine("Queue is Empty");
                return error;
            }
        }
        public void PrintAll()
        {
            for (int i = front; i < rear; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           // LinearQueue<int> q = new LinearQueue<int>();
           // q.Enqueue(1);
           // q.Enqueue(2);
           // q.Enqueue(3);
           // q.Enqueue(4);
           // q.Enqueue(5);
           // q.Enqueue(6);
           //
           // q.PrintAll();
           // Console.WriteLine();
           // Console.WriteLine("Peek 값 : " + q.Peek());
           // Console.WriteLine("Queue의 크기 값 : " + q.Count());
           // Console.WriteLine();
           //
           // Console.WriteLine("Queue에서 " + q.Dequeue() + "값이 나왔습니다.");
           // Console.WriteLine("Queue에서 " + q.Dequeue() + "값이 나왔습니다.");
           // Console.WriteLine("Queue의 크기 값 : " + q.Count());
           // q.PrintAll();
        }
    }
}
