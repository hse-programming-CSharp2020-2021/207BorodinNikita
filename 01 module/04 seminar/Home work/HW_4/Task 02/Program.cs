using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод чисел будет продолжаться до команды \"!\" в консоль или суммы отрицательных чисел меньше -1000");

            int result = 0, iterator = 0; string input;

            do
            {
                input = Console.ReadLine();

                if (!int.TryParse(input, out int value) && input != "!")
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                if (value < 0)
                {
                    result += value;
                    iterator++;
                }

            } while (input != "!" && result >= -1000);

            Console.WriteLine($"Среднее арифметическое: {(result/iterator):F2}");
        }
    }
}
