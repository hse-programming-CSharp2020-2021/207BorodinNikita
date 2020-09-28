using System;
using System.Linq;

namespace task_9
{
    class Program
    {
        static void Replace(int[] array, int maxValue, int replace)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == Array.FindIndex(array, j => j == maxValue))
                {
                    array[i] = replace;
                }
            }
        }

        static int[] Generate(int length)
        {
            Random random = new Random();

            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-9, 10);
            }

            return array;
        }
        static void Main(string[] args)
        {
            if(!int.TryParse(Console.ReadLine(), out int length))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

             int[] myArray = Generate(length);

            Console.WriteLine("Введите значение для замены");
            if (!int.TryParse(Console.ReadLine(), out int replace))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int maxValue = myArray.Max();

            foreach (var item in myArray)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine();
            Replace(myArray, maxValue, replace);

            foreach (var item in myArray)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
