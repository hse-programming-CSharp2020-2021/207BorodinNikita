using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());

            uint iterator = 0;

            while (iterator * iterator / 2 < N) 
            {
                iterator++;
            }

            uint[][] myArray = new uint[iterator][];

            for (uint i = 0; i < iterator; i++) 
            {
                if (N > i)
                {
                    myArray[i] = new uint[i + 1] ;
                }
                else
                {
                    myArray[i] = new uint[N];
                }

                for (int j = 0; j <= i && N > 0; j++)
                {
                    myArray[i][j] = N--;
                }
            }

            for (int i = 0; i < iterator; i++)
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
