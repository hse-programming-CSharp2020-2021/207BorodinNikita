using System;

namespace Task_02
{
    class Program
    {
        static void FillArray(uint[] array)
        {
            for (uint i = 1; i <= array.Length; i++)
            {
                array[i - 1] = 2 * i - 1;
            }
        }
        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint arrayLength))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            uint[] myArray = new uint[arrayLength];

            FillArray(myArray);

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
