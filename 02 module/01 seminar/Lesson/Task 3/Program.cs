using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] a = new char[3][][];

            a[0] = new char[3][];
            a[1] = new char[2][];
            a[2] = new char[1][];

            a[0][0] = new char[2];
            a[0][1] = new char[3];
            a[0][2] = new char[4];

            a[1][0] = new char[2];
            a[1][1] = new char[3];

            a[2][0] = new char[4];

            Random random = new Random();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    for (int k = 0; k < a[i][j].GetLength(0); k++)
                    {
                        a[i][j][k] = (char)random.Next('a', 'z');

                        Console.Write($"{a[i][j][k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
