using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static int[] Generate(int length)
        {
            Random random = new Random();

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(-10, 11);
            }

            return array;
        }

        static void ResizeOdd(ref int[] array)
        {
            int newLength = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    array[newLength++] = array[i];
                }
            }

            if (newLength > 0) Array.Resize(ref array, newLength);
        }
        static void Main(string[] args)
        {
            int[] myArray = Generate(int.Parse(Console.ReadLine()));

            ResizeOdd(ref myArray);

            Array.ForEach(myArray, i => Console.Write($"{i} "));
        }
    }
}
