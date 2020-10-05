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

            for (uint i = 0, k = N; i < N; i++, k++)
            {
                {
                    myArray[i] = new char[k];
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                   myArray[i][j] = '*';
                }
            }

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = (int)(N - 2 - i); j >= 0; j--)
                {
                    myArray[i][j] = ' ';
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
