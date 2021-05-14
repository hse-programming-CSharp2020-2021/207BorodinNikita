using System;

namespace Task_01._3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!byte.TryParse(Console.ReadLine(), out byte N))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            byte[,] myArray = new byte[N, N];

            if (N % 2 == 1)
            {
                myArray[N / 2, N / 2] = 1;
            }

            byte M = (byte)(N * N);

            N = (byte)(N / 2 + N % 2);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j % 4 == 0)
                    {
                        for (int k = i; k < myArray.GetLength(0) - 1 - i; k++)
                        {
                            myArray[i, k] = M--;
                        }
                    }
                    if (j % 4 == 1)
                    {
                        for (int k = i; k < myArray.GetLength(0) - 1 - i; k++)
                        {
                            myArray[k, myArray.GetLength(0) - 1 - i] = M--;
                        }
                    }
                    if (j % 4 == 2)
                    {
                        for (int k = myArray.GetLength(0) - 1 - i; k > i; k--)
                        {
                            myArray[myArray.GetLength(0) - 1 - i, k] = M--;
                        }
                    }
                    if (j % 4 == 3)
                    {
                        for (int k = myArray.GetLength(0) - 1 - i; k > i; k--)
                        {
                            myArray[k, i] = M--;
                        }
                    }
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
