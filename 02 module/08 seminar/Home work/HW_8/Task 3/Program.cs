using System;
using MyLib;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = 'к', finish = 'ю';
            do
            {
                MyStrings testString = new RusString(start, finish, 10);

                Console.WriteLine(testString);
                Console.WriteLine(testString.CountLetter('о'));
                Console.WriteLine(testString.IsPalidrome());

                try
                {
                    testString = new RusString(start, finish, -11);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Nothing was changed.");
                }

                Console.WriteLine(testString);
                Console.WriteLine(testString.CountLetter('о'));
                Console.WriteLine(testString.IsPalidrome());

                testString = new LatString(start, finish, 10);

                Console.WriteLine(testString);
                Console.WriteLine(testString.CountLetter('о'));
                Console.WriteLine(testString.IsPalidrome());

                try
                {
                    testString = new RusString(start, finish, -11);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Nothing was changed.");
                }

                Console.WriteLine(testString);
                Console.WriteLine(testString.CountLetter('о'));
                Console.WriteLine(testString.IsPalidrome());

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }

}