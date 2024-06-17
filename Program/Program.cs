namespace Program
{
    public class CircularQueue<T>
    {
        private int count;
        private int arraySize;
        private T[] array;
        private int front;
        private int rear;
        private T error;
        
        public int Count()
        {
            return count;
        }

        public CircularQueue()
        {
            count = 0;
            arraySize = 5;
            array = new T[arraySize];
            front = arraySize - 1;
            rear = arraySize - 1;
        }

        public void Enqueue(T data)
        {
            if (rear!=(front-1)%arraySize)
            {
                rear = (rear + 1) % arraySize;
                array[rear] = data;
                count++;
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
                T result = array[(front+1)%arraySize];
                array[(front + 1) % arraySize] = error;
                front=(front+1)% arraySize;
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
            return array[(front + 1) % arraySize];
        }

        public void PrintAll()
        {
            int start = (front + 1) % arraySize;
            for(int i = start; i < start+count; i++)
            {
                Console.WriteLine(array[i % arraySize]);
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            CircularQueue<int> q = new CircularQueue<int>();
             q.Enqueue(1);
             q.Enqueue(2);
            Console.WriteLine("Queue에서 " + q.Dequeue() + "값이 나왔습니다."); 
            Console.WriteLine("Queue에서 " + q.Dequeue() + "값이 나왔습니다."); 
            Console.WriteLine("Queue에서 " + q.Dequeue() + "값이 나왔습니다.");
            q.Enqueue(3);
             q.Enqueue(4);
             q.Enqueue(5);
             q.Enqueue(6);
            
             q.PrintAll();
             Console.WriteLine();
             Console.WriteLine("Peek 값 : " + q.Peek());
             Console.WriteLine("Queue의 크기 값 : " + q.Count());
             Console.WriteLine();
            
             Console.WriteLine("Queue에서 " + q.Dequeue() + "값이 나왔습니다.");
             Console.WriteLine("Queue에서 " + q.Dequeue() + "값이 나왔습니다.");
             Console.WriteLine("Queue의 크기 값 : " + q.Count());
             q.PrintAll();
        }
    }
}
