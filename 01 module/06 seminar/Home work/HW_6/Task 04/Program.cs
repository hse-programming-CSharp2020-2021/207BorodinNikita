using System;

namespace Task_04
{
    class Program
    {
        static void AddToArray(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];

            Array.Copy(array, newArray, array.Length);

            newArray[array.Length] = value;

            array = newArray;
        }
        static int[] GetArray(int input)
        {
            int output = input;

            int[] array = {input};
            do
            {
                output = output % 2 == 0 ? output / 2 : 3 * output + 1;

                AddToArray(ref array, output);

            } while (output != 1);

            return array;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray(int.Parse(Console.ReadLine()));

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"[{i}] = {myArray[i]}\t");

                if ((i + 1) % 5 == 0) 
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
