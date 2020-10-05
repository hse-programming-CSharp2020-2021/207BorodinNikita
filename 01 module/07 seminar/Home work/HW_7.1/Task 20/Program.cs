using System;

namespace Task_20
{
    class Program
    {
        static void Compare(int[] array, uint item)
        {
            Array.ForEach(array, i => Console.Write($"{i} "));

            ArrayItemDouble(ref array, item);
            Console.WriteLine();

            Array.ForEach(array, i => Console.Write($"{i} "));
        }
        static void ArrayItemDouble(ref int[] array, uint item)        {
            int length = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    length++;
                }
            }

            int[] newArray = new int[array.Length + length];
            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (array[j] == item)
                {
                    newArray[i] = array[j];
                    newArray[++i] = array[j];
                }

                newArray[i] = array[j];
            }

            array = newArray;
        }
        static int[] Generate(uint length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Random random = new Random();

                array[i] = random.Next(10, 101);
            }

            return array;
        }
        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint length))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (!uint.TryParse(Console.ReadLine(), out uint item))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[] myArray = Generate(length);

            Compare(myArray, item);
        }
    }
}
