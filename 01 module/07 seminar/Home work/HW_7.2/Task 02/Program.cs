using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint N) || N % 2 == 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            char[][] myArray = new char[N][];

            for (uint i = 0; i < N; i++)
            {
                {
                    myArray[i] = new char[i + 1];
                }

                for (int j = 0; j <= i; j++)
                {
                    myArray[i][j] = '*';
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write($"\t{myArray[i][j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
