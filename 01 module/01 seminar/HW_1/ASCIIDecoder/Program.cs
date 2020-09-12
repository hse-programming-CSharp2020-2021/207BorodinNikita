using System;


namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Code = byte.Parse(Console.ReadLine());

            Console.WriteLine((char)Code);
        }
    }
}
