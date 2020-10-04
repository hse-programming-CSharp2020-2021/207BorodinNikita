using System;

namespace Metanit.com
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas =
            {
                { { 1, 2 }, { 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
            };

            Console.Write("{");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if ((mas.GetLength(2) - k) != 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.Write("}");
                    if ((mas.GetLength(1) - j) != 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("}");
                if ((mas.GetLength(0) - i) != 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("}");
        }
    }
}
