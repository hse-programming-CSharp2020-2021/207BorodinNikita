using System;

namespace Task_06
{
    class Program
    {
        static void DeleteElement(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0, j = 0; i < newArray.Length; j++)
            {
                if (j == index)
                {
                    continue;
                }

                newArray[i] = array[j];
                i++;
            }

            array = newArray;
        }
        static void Compress(ref int[] array, ref int iterator)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] + array[i + 1]) % 3 == 0)
                {
                    array[i] *= array[i + 1];
                    DeleteElement(ref array, i + 1);
                    iterator++;
                }
            }
        }
        static int CompressIterartions(ref int[] array)
        {
            int lastLength; int iterator = 0;
            do
            {
                lastLength = array.Length;

                Compress(ref array, ref iterator);

            } while (lastLength != array.Length);

            return iterator;
        }
        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint N))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int[] myArray = new int[N];

            for (int i = 0; i < N; i++)
            {
                Random random = new Random();

                myArray[i] = random.Next(-10, 11);
            }

            foreach (var item in myArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int iterator = CompressIterartions(ref myArray);

            foreach (var item in myArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine($"\nCount of compressions: {iterator}");
        }
    }
}
