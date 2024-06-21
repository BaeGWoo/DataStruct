namespace Class8th__String_
{
    public class String
    {
        private char[] arr;
        int size;

        public String()
        {
            arr = null;
            size = 0;
        }



        public int Size()
        {
            return size;
        }

        public void Add(char[] content)
        {
            int newSize = content.Length;
            arr = new char[newSize + 1];
            for (int i = 0; i < newSize; i++)
            {
                arr[i] = content[i];
            }
            size = newSize;
        }


        public void Show()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        public void ConCat(char[] content)
        {
            int newSize = content.Length + size;
            char[] newArr = new char[newSize + 1];
            for (int i = 0; i < size; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = 0; i < content.Length; i++)
            {
                newArr[i + size] = content[i];
            }
            arr = newArr;
            size = newSize;
        }

        public bool Equal(char[] content)
        {
            if (size != content.Length)
                return false;

            for (int i = 0; i < size; i++)
            {
                //int pivot = arr[i];
                //int target = (int)content[i];
                if ((int)arr[i] != (int)content[i])
                    return false;
            }
            return true;
        }

        public int IndexOf(char target)
        {
            int result = -1;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == target)
                {
                    result = i;
                    //return result;
                    break;
                }
            }
            return result;
        }

        public bool Contains(char[] target)
        {
            int count = 0;
            for (int i = 0; i < size - target.Length + 1; i++)
            {
                for (int j = 0; j < target.Length; j++)
                {
                    if (arr[i + j] == target[j])
                        count++;

                    if (count == target.Length)
                    {
                        if ((i + j + 1 < size) && arr[i + j + 1] == ' ') ;
                        return true;
                    }
                }
                count = 0;
            }
            return false;
        }


        public bool Contain2(char[] target)
        {
            int index = 0;
            char cur = ' ';
            for (int i = 0; i < size; i++)
            {

                if (arr[i] == target[index])
                    index++;

                else index = 0;

            }

            if (index == target.Length)
                return true;
            return false;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            String str1 = new String();
            //str1.Add(new char[] { 'X', 'X', 'X', ' ', ' ','X',' ','X','X','X','X' });
            str1.Add(new char[] { 'A', 'B', 'X', ' ', ' ', 'X', ' ', 'D', 'C', 'F', 'X' });
            // //str1.Add(new char[] {  });
            // str1.Show();
            // Console.WriteLine();
            // //str1.ConCat(new char[] { '9', '7' });
            // Console.WriteLine("str1의 크기 : " + str1.Size());
            // str1.Show();
            //
            // Console.WriteLine();
            // Console.WriteLine(str1.Equal(new char[] { 'A', '2', '3', 'C', 'D' }));
            // //Console.WriteLine(str1.Equal(new char[] {  }));
            // Console.WriteLine(str1.IndexOf('2'));
            //
            // Console.WriteLine(str1.Contains(new char[] { '3', 'B', 'C' }));
            Console.WriteLine(str1.Contain2(new char[] { 'A' }));

        }
    }
}
