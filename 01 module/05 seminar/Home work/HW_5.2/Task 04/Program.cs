using System;

namespace Task_02
{
    class Program
    {
        static void FillArray(int[] array)
        {
            array[0] = array[1] = 1;
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 2] + array[i - 1]; ;
            }
        }
        static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int arrayLength) || arrayLength < 2 || arrayLength > 45)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[] myArray = new int[arrayLength];

            FillArray(myArray);

            for (int i = --arrayLength; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
