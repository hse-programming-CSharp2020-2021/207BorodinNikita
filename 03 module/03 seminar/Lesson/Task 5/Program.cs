using System;

namespace Task_5
{
    delegate void MatrixDel(int[,] mat, int c, int r);

    abstract class Matrix
    {
        // Вообще не то сделал

        public static event MatrixDel OnRowChanged;
        public static event MatrixDel OnColumnChanged;
        public static void  Print(int[,] matrix, int columnNumber = 0, int rowNumber = 0)
        {
            if (rowNumber == matrix.GetLength(0))
                return;

            Console.Write($"\t{matrix[rowNumber, columnNumber++]}");

            if (columnNumber == matrix.GetLength(1))
            {
                Console.WriteLine();
                OnRowChanged?.Invoke(matrix, 0, ++rowNumber);
                return;
            }

            OnColumnChanged?.Invoke(matrix, columnNumber, rowNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix.OnRowChanged += Matrix.Print;
            Matrix.OnColumnChanged += Matrix.Print;

            int[,] matrix = new int[5, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(0, 11);
                }
            }

            Matrix.Print(matrix);
        }
    }
}
