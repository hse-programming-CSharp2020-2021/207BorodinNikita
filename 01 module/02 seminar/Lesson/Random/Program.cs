using System;

namespace random
{
    class Program
    {
        static void Stroke()
        {
            Random rnd = new Random();

            string str = "";

            for (int i = 0; i < rnd.Next(1, 20); i++)
            {
                str += (char)rnd.Next('a', 'z' + 1);
            }

            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Stroke();
            }
        }
    }
}
