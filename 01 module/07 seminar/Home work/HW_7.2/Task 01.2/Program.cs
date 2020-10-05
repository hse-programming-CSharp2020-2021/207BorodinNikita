using System;

namespace Task_01._2
{
    class Program
    {
        static void Main(string[] args)
        {

            if(!byte.TryParse(Console.ReadLine(), out byte N))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            sbyte[,] myArray = new sbyte[N, N];

            for (int j = 0; j < myArray.GetLength(0); j++)
            {
                for (int i = 0; i < myArray.GetLength(0) - j - 1; i++)
                {
                    myArray[j, i] = -1;
                }
                for (int i = myArray.GetLength(0) - 1; i > myArray.GetLength(0) - j - 1; i--)
                {
                    myArray[j, i] = 1;
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write($"\t{myArray[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
