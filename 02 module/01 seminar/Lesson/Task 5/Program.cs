using System;

namespace Task_5
{
    class Program
    {
        static void Create(int N, out int[][] array)
        {
            int[][] newArray = new int[N][];

            for (int i = 1; i <= N; i++)
            {
                newArray[i - 1] = new int[i];
            }

            array = newArray;
        }

        static void Fill(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].GetLength(0); j++)
                {
                    if (j == 0 || j == array[i].GetLength(0) - 1)
                        array[i][j] = 1;
                    else
                        array[i][j] = array[i - 1][j - 1] + array[i - 1][j];
                }
            }
        }

        static void WriteArray(int[][] array)
        {
            foreach (var item1 in array)
            {
                foreach (var item2 in item1)
                {
                    Console.Write($"{item2} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Create(N, out int[][] myArray);

            Fill(myArray);

            WriteArray(myArray);
        }
    }
}
