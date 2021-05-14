using System;

namespace ConsoleApp1
{
    class Program
    {
        static bool Shift(ref char symbol, string napr)
        {
            if ((int)symbol >= (int)'a' && (int)symbol <= (int)'z')
            {
                switch (napr)
                {
                    case "right":
                        symbol = (int)symbol + 4 <= (int)'z' ? (char)((int)symbol + 4) : (char)((int)'a' + (4 - ((int)'z' - (int)symbol)));
                        return true;
                    case "left":
                        symbol = (int)symbol - 4 >= (int)'a' ? (char)((int)symbol - 4) : (char)((int)'z' - (4 - ((int)(symbol) - (int)'a')));
                        return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            Shift(ref symbol, "left");

            Console.WriteLine(symbol);
        }
    }
}


