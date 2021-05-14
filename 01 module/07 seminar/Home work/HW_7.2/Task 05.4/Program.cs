using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint N))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[,] matrix = new int[N, N];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Random random = new Random();

                    matrix[i, j] = random.Next(0, 26);
                }
            }

            bool exception = true;

            string[,] newMatrix = new string[N, N];

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = " ";
                }
            }

            for (int i = 1, k = i; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = matrix.GetLength(0) - 1; j > matrix.GetLength(0) - 1 - k; j--)
                {
                    if (i <= N / 2 + N % 2 - 1)
                        newMatrix[matrix.GetLength(0) - 1 - j, i] = matrix[matrix.GetLength(0) - 1 - j, i].ToString();
                    else
                        newMatrix[j, i] = matrix[j, i].ToString();

                    if (i == N / 2 + N % 2 - 1 && N % 2 == 1)
                    {
                        newMatrix[matrix.GetLength(0) - 1 - j, i] = matrix[matrix.GetLength(0) - 1 - j, i].ToString();

                        newMatrix[j, i] = matrix[j, i].ToString();
                    }
                }

                if (i < N / 2 + N % 2 - 1)
                {
                    k++;
                }
                else
                {
                    if (N % 2 == 0 && exception)
                        exception = false;
                    else
                        k--;
                }
            }

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    Console.Write($"\t{newMatrix[i, j]}");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
