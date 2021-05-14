using System;

namespace Task_01
{
 
    class Program
    {
        static void FillArray(ulong[] array)
        {
            for (byte i = 0; (int)i < array.Length; i++)
            {
                array[i] = (ulong)Math.Pow(2, i);
            }
        }
        static void Main(string[] args)
        {
            if (!byte.TryParse(Console.ReadLine(), out byte arrayLength) || arrayLength > 64)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            ulong[] myArray = new ulong[arrayLength];

            FillArray(myArray);

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
