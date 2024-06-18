using System.Data.Common;
using System.Drawing;

namespace Program
{
  
public class Vector<T>
    {
        private int size;
        private int capacity;
        private T[] arr;
        private T error;

        public Vector()
        {
            size = 0;
            capacity = 0;
            arr = null;
        }

        public int Size()
        {
            return size;
        }

        public void Resize(int newSize)
        {
            T[] temp = new T[newSize];
            for (int i = 0; i < size; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
            temp = null;
            capacity = newSize;
        }

        public void Add(T data)
        {
            if (arr == null)
            {
                Resize(1);
            }

            else
            {
                if (size == capacity)
                {
                    Resize(capacity * 2);
                }
            }
            arr[size] = data;
            size++;
        }

        public void Reserve(int newSize)
        {
            if (newSize > capacity)
            {
                Resize(newSize);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < size)
            {
                for(int i = index; i < size-1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[size - 1] = error;
                size--;
            }

            else
            {
                Console.WriteLine("index is out of Range");
            }
        }

    public T this[int index]
        {
            get { return arr[index]; }
        }
            

      
    }
    internal class Program
    {

        static void Main(string[] args)
        {
           Vector<int> vector = new Vector<int>();
            vector.Add(1);
            vector.Add(2);
            vector.Add(3);
            vector.Add(4);
            vector.Add(5);
            vector.Add(6);

            vector.RemoveAt(4);
            for (int i = 0; i < vector.Size(); i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
