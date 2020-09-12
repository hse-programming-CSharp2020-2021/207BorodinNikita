using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] Surname = new char[5, 30];
            
            for (int i = 0; i < Surname.GetLength(0); i++)
            {
                for (int j = 0; j < Surname.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j != 3 && j != 7 && j != 11 && j != 15 && j != 16 && j != 20 && j != 21 && j != 23 && j != 24 && j != 26 && j != 28)
                        {
                            Surname[i, j] = 'X';
                        }
                    }
                    if (i == 1)
                    {
                        if (j != 1 && j != 2 && j != 3 && j != 5 && j != 7 && j != 9 && j != 11 && j != 13 && j != 15 && j != 16 && j != 18 && j != 20 && j != 21 && j != 23 && j != 26 && j != 28)
                        {
                            Surname[i, j] = 'X';
                        }
                    }
                    if (i == 2)
                    {
                        if (j != 3 && j != 5 && j != 7 && j != 11 && j != 13 && j != 15 && j != 16 && j != 18 && j != 20 && j != 21 && j != 26)
                        {
                            Surname[i, j] = 'X';
                        }
                    }
                    if (i == 3)
                    {
                        if (j != 1 && j != 3 && j != 5 && j != 7 && j != 9 && j != 10 && j != 11 && j != 13 && j != 15 && j != 21 && j != 24 && j != 26 && j != 28)
                        {
                            Surname[i, j] = 'X';
                        }
                    }
                    if (i == 4)
                    {
                        if (j != 3 && j != 7 && j != 9 && j != 10 && j != 11 && j != 15 && j != 17 && j != 18 && j != 19 && j != 21 && j != 23 && j != 24 && j != 26 && j != 28)
                        {
                            Surname[i, j] = 'X';
                        }
                    }
                    Console.Write(Surname[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
