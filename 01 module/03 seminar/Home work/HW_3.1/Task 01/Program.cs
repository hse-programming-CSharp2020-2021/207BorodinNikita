using System;

namespace Task_01
{
    class Program
    {
        static double MyFunction(ref int iterator)
        {
            double result = 0;
            iterator = 0;

            while (result < 1000)
            {
                result = iterator * (iterator + 1) / 2;

                if ((int)(result / 111) == result / 111 && iterator > 14) 
                {
                    return result;
                }

                iterator++;
            }

            return 0;
        }
        static void Main(string[] args)
        {
            int iterator = 0;

            Console.WriteLine($"Полученное число: {(int)MyFunction(ref iterator)}\nВсего чисел в ряду: {iterator}");

            Console.WriteLine($"1+2+3+...+{iterator-2}+{iterator-1}+{iterator}");
        }
    }
}
