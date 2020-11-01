using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a count of rows and columns of the array");

            if (!int.TryParse(Console.ReadLine(), out int N) || N == 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine();

            int[,] myArray = new int[N, N];

            for (int i = 0, counter = 1; i < myArray.GetLength(0); i++, counter ++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++, counter++)
                {
                    myArray[i, j] = counter % N == 0 ? N : counter % N;

                    Console.Write($"\t{myArray[i, j]}");
                }

                Console.WriteLine();
            }
        }
    }
}
