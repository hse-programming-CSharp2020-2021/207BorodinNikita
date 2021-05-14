using System;
using System.Linq;

namespace Task_16
{
    class Program
    {
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

            Console.WriteLine($"Index of Min value: {Array.FindIndex(myArray, i => i == myArray.Min())}");

            int sumOfIndexes = 0;

            for (int i = 0; i < length; i++)
            {
                if (myArray[i] == myArray.Min() || myArray[i] == myArray.Max())
                {
                    sumOfIndexes += i;
                }
            }

            Console.WriteLine($"Sum of Min and Max value indexes: {sumOfIndexes}");
        }
    }
}
