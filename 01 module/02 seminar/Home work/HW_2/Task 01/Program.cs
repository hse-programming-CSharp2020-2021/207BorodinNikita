using System;

namespace Task_01
{
    class Program
    {
        static int Function(int x)
        {
            return x * (x * (x * (12 * x + 9) - 3) + 2) - 4;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");

            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Ошибка!");
                return;
            }

            Console.WriteLine($"F({x}) = {Function(x)}");

            Console.ReadLine();
        }
    }
}



