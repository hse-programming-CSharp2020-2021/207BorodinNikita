using System;

namespace Task_04
{
    class Program
    {
        static dynamic Det(int[,] matrix)
        {
            if (matrix.GetLength(0) == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            if (matrix.GetLength(0) == 3)
            {
                int positive = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
                    matrix[2, 0] * matrix[0, 1] * matrix[1, 2] +
                    matrix[0, 2] * matrix[1, 0] * matrix[2, 1];

                int negative = matrix[2, 0] * matrix[1, 1] * matrix[0, 2] +
                    matrix[0, 0] * matrix[2, 1] * matrix[1, 2] +
                    matrix[2, 2] * matrix[1, 0] * matrix[0, 1];

                return positive - negative;
            }
            else
            {
                return null;
            }
        }
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

                    matrix[i, j] = random.Next(int.MinValue, int.MaxValue);

                    Console.Write($"\t{matrix[i, j]}");
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine($"Determinant: {Det(matrix) ?? "Wrong size of matrix"}");
        }
    }
}
