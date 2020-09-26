using System;

namespace skdglq
{
    class Program
    {
        static void Generate(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);
            }
        }

        static void Add(ref int[] a, int[] b)
        {
            int[] add = Array.FindAll(b, i => i % 2 == 1);

            int[] newArray = new int[a.Length + add.Length];

            for (int i = 0; i < a.Length; i++)
            {
                newArray[i] = a[i];
            }
            for (int i = a.Length, j = 0; i < newArray.Length; i++)
            {
                newArray[i] = add[j];
            }

            a = newArray;
        }
        static void Main(string[] args)
        {
            int firstArrayLength = int.Parse(Console.ReadLine());
            int[] a = new int[firstArrayLength];
            Generate(a);

            int secondArrayLength = int.Parse(Console.ReadLine());
            int[] b = new int[secondArrayLength];
            Generate(b);

            Add(ref a, b);

            foreach (var item in a)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
