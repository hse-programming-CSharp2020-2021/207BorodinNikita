using System;
using System.Linq;

namespace HW_7
{
    class Program
    {
        static void ArrayHill(int[] array)
        {
            int[] newArray = array.OrderBy(i => i).ToArray();

            for (int i = 0, j = 0, k = 1; i < array.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    array[j] = newArray[i];
                    j++;
                }
                else
                {
                    array[^k] = newArray[i];
                    k++;
                }
            }
        }
        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint length))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int[] myArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                Random random = new Random();

                myArray[i] = random.Next(-10, 11);
            }

            Array.ForEach(myArray, i => Console.Write($"{i} "));

            Console.WriteLine(); ArrayHill(myArray);

            Array.ForEach(myArray, i => Console.Write($"{i} "));
        }
    }
}
