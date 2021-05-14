using System;

namespace Task_03
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
        static void Swap(int[] array)
        {
            int[] newArray1 = Array.FindAll(array, i => i >= 0);

            int[] newArray2 = Array.FindAll(array, i => i < 0);

            for (int i = 0; i < array.Length; i++)
            {
                if (i < newArray1.Length)
                {
                    array[i] = newArray1[i];
                }
                else
                {
                    array[i] = newArray2[i - newArray1.Length];
                }
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[int.Parse(Console.ReadLine())];

            Generate(myArray);

            Swap(myArray);

            Array.ForEach(myArray, i => Console.Write($" {i}"));
        }
    }
}
