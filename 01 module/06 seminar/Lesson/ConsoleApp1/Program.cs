using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Generator(char[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)random.Next((int)'A', (int)'Z' + 1);
            }
        }
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            char[] letters = new char[length];

            Generator(letters);

            Array.Sort(letters);

            Array.ForEach(letters, i => Console.Write($"{i}\t"));
        }
    }
}
