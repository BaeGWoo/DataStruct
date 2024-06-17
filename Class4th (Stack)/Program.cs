namespace Class4th__Stack_
{

    public class Stack<T>
    {
        private T[] array;
        private int top;
        private int count;
        private readonly int arraySize;
        private T error;
        public Stack()
        {
            arraySize = 10;
            array = new T[arraySize];
            top = -1;
            count = 0;
        }
        public int Count()
        {
            return count;
        }

        public int Size()
        {
            return top + 1;
        }

        public void Push(T data)
        {
            if (top >= arraySize - 1)
            {
                Console.WriteLine("Stack OverFlow");
            }
            else
            {
                array[++top] = data;
                count++;
            }
        }

        public T Peek()
        {
            return array[top];
        }

        public void Show()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public T Pop()
        {
            if (top <= -1)
            {
                Console.WriteLine("Stack is Empty");
                return error;
            }

            else
            {
                count--;
                return array[top--];
            }
        }

        public bool Contains(T data)
        {
            for (int i = 0; i <= top; i++)
            {
                if (array[i].ToString() == data.ToString())
                    return true;
            }
            return false;
        }
    }
    internal class Program
    {
        static bool CheckBracket(string content)
        {
            if (content.Length <= 0)
                return false;

            Stack<char> stack = new Stack<char>();
            char[] type = new char[6] { '{', '}', '[', ']', '(', ')' };
            int type1 = 0;
            int type2 = 0;
            int type3 = 0;

            for (int i = 0; i < content.Length; i++)
            {
                stack.Push(content[i]);
            }

            int size = stack.Size();
            for (int i = 0; i < size; i++)
            {
                char result = stack.Pop();
                for (int j = 0; j < type.Length; j++)
                {
                    if (result == type[j])
                    {
                        int Bracket = j / 2;
                        int BracketType = j % 2;
                        switch (Bracket)
                        {
                            case 0:
                                if (BracketType == 0)
                                    type1++;
                                else
                                    type1--;
                                break;

                            case 1:
                                if (BracketType == 0)
                                    type2++;
                                else
                                    type2--;
                                break;

                            case 2:
                                if (BracketType == 0)
                                    type3++;
                                else
                                    type3--;
                                break;
                        }
                        if (type1 > 0 || type2 > 0 || type3 > 0)
                            return false;
                    }
                }
            }

            if (type1 != 0 || type2 != 0 || type3 != 0)
                return false;

            return true;
        }

        static bool BracketCheck(string content)
        {
            if (content.Length <= 0)
                return false;

            Stack<int> stack = new Stack<int>();
            char[] type = new char[6] { '{', '}', '[', ']', '(', ')' };

            for (int i = 0; i < content.Length; i++)
            {
                for (int j = 0; j < type.Length; j++)
                {
                    if (content[i] == type[j])
                    {
                        if (j < 3)
                        {
                            stack.Push(j);
                            break;
                        }

                        else
                        {
                            if (stack.Pop() != j/2)
                                return false; 
                        }
                    }
                }
            }
            if (stack.Count() != 0)
                return false;

            else
                return true;
           
        }
        static void Main(string[] args)
        {
            //Stack<int> stack = new Stack<int>();
            // stack.Push(10);
            // stack.Push(20);
            // stack.Push(30);
            // stack.Push(40);
            // stack.Push(50);
            // stack.Push(60);
            //
            // Console.WriteLine("Stack의 Peek 값 : "+stack.Peek()+"\n");
            // stack.Show();
            // Console.WriteLine(CheckBracket("{{()]}"));
            // Console.WriteLine(CheckBracket("{}()"));
        }
    }
}
