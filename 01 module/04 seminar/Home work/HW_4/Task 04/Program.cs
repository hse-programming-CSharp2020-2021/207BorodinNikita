using System;

namespace Task_04
{
    class Program
    {
        static dynamic BitShift(byte power)
        {
            if (power > 31)
            {
                return null;
            }
            return ((uint)1 << power);
        }
        static void Main(string[] args)
        {
            if (!byte.TryParse(Console.ReadLine(), out byte N) || !byte.TryParse(Console.ReadLine(), out byte M))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (N == 31 && M == 31)
            {
                Console.WriteLine("Overflow error");
                return;
            }

            Console.WriteLine((BitShift(N) ?? "") + (BitShift(M) ?? "Overflow error"));
        }
    }
}
