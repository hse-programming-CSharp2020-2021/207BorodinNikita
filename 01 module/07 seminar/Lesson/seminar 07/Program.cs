using System;

namespace seminar_07
{
    class Program
    {
        static void Main(string[] args)
        {

            byte N = byte.Parse(Console.ReadLine());

            sbyte[,] myArray = new sbyte[N, N];

            for (int j = 0; j < myArray.GetLength(0); j++)
            {
                for (int i = myArray.GetLength(1) - 1; i > j; i--)
                {
                    myArray[j, i] = 1;
                }
                for (int i = 0; i < j; i++)
                {
                    myArray[j, i] = -1;
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
