using System;

namespace Task_02
{
    class Program
    {
        static void FillArray(int[] array, int A, int D)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = A + D * i;
            }
        }
        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int arrayLength) || arrayLength < 2)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out int A))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out int D) || D * (arrayLength - 1) > Math.Pow(2, 30))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[] myArray = new int[arrayLength];

            FillArray(myArray, A, D);

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
