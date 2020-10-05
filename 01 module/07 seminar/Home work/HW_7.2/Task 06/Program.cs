using System;

namespace Task_06
{
    class Program
    {
        static int[] Foo(int[,] matrix)
        {
            int[,] left = new int[3, 3];
            int[,] right = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) / 2; j++)
                {
                    left[i, j] = matrix[i, j];

                    right[i, j] = matrix[i, j + matrix.GetLength(1) / 2];
                }
            }

            int[] output = { Det(left), Det(right) };

            return output;
        }
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
            int[,] matrix = new int[3, 6];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Random random = new Random();

                    matrix[i, j] = random.Next(0, 21);
                }
            }

            int[] result = Foo(matrix);

            Console.WriteLine("Left determinant: {0}\nRight determinant: {1}", result[0], result[1]);
        }
    }
}
