using System;

namespace HomeTask10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void AddNum(ref int[] arr, int val)
        {
            int[] array = new int[arr.Length + 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = arr[i];
            }
            array[arr.Length] = val;

            arr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = array[i];
            }

        }

        static void WithoutSpace(ref string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    chars[i] = '-';
                }
            }
            Console.WriteLine(chars);

        }

        static void FindRoot(ref int number)
        {
            int root = 0;
            for (int i = 1; i * i < number; i++)
            {
                root = i;
            }
            number = root;
        }

        static int NewNumber(int number)
        {
            int k = number;
            int count = 1;
            while (k!=0)
            {
                k /= 10;
                count *= 10;
            }
            int a = number % 10;
            number /= 10;
            count /= 10;
            int newNumber = a * count + number;
            return newNumber;
        }
    }
}
