using System;
using System.Collections.Generic;
using System.Linq;

namespace var_01
{
    class Program
    { 
        static int[] Primes(int[] myArray)
        {
            int result = 0;

            List<int> resultList = new List<int>();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 1, count = 0; j <= myArray[i]; j++)
                {
                    if (myArray[i] % j == 0)
                    {
                        count++;

                        if (count > 2)
                        {
                            break;
                        }
                    }

                    if (j == myArray[i])
                    {
                        result++;
                        resultList.Add(myArray[i]);
                    }
                }
            }

            Console.WriteLine($"Количество простых чисел: {result}");

            return resultList.ToArray();
        }

        static bool IsNonDecreasing(int[] myArray)
        {
            int[] checkArray = myArray.Distinct().ToArray();

            Console.WriteLine($"Минимальный элемент последовательности: {checkArray.Min()}");

            return Check(checkArray);
        }
        static bool Check(int[] checkArray)
        {
            for (int i = 0; i < checkArray.Length - 1; i++)
            {
                if (checkArray[i] > checkArray[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            ConsoleKey consoleKey;
            do
            {
                Console.Clear();

                Console.WriteLine("Введите число элементов последовательности:");
                if (!uint.TryParse(Console.ReadLine(), out uint N) || N > 10000)
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                int[] myArray = new int[N];

                Random random = new Random();

                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = random.Next(0, 21);
                }

                foreach (var item in Primes(myArray))
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine($"{Environment.NewLine}");

                if (IsNonDecreasing(myArray))
                    Console.WriteLine("Последовательность является неубывающей");

                else
                    Console.WriteLine("Последовательность не является неубывающей");

                Console.WriteLine("\nДля выхода нажмите Esc, для продолжения - любую другую клавишу");
                consoleKey = Console.ReadKey().Key;

            } while (consoleKey != ConsoleKey.Escape);
        }
    }
}
