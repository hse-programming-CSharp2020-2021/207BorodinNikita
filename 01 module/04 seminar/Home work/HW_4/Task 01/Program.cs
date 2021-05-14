using System;

namespace Task_01
{
    class Program
    {
        static void AddToABC(int i, int j, int k, ref int[] a, ref int[] b, ref int[] c)
        {
            Add(ref a, i);

            Add(ref b, j);

            Add(ref c, k);
        }
        static void CheckAndAdd(int i, int j, int k, ref int[] a, ref int[] b, ref int[] c)
        {
            if (i * i + j * j == k * k)
            {
                if (i != j && j != k && k != i)
                {
                    int indexOfC = Array.FindIndex(c, l => l == k);

                    if (indexOfC == -1)
                    {
                        AddToABC(i, j, k, ref a, ref b, ref c);
                        return;
                    }
                }
            }
        }
        static void Add(ref int[] array, int element)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[array.Length] = element;

            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] a = new int[0];

            int[] b = new int[0];

            int[] c = new int[0];

            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    for (int k = 0; k < 21; k++)
                    {
                        CheckAndAdd(i, j, k, ref a, ref b, ref c);
                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}\t{b[i]}\t{c[i]}");
            }
        }
    }
}
