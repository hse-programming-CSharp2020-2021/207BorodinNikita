using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Split(int N)
        {
            int length = (int)Math.Log10(N) + 1;

            char[] symbols = new char[length];

            for (int i = symbols.Length - 1; i >= 0; i--)
            {
                symbols[i] = (char)(N % 10 + '0');

                N = (N - N % 10) / 10;
            }

            Array.ForEach(symbols, i => Console.Write($"{i}\t"));
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Split(N);
        }
    }
}
