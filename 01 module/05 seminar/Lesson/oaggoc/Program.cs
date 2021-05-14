using System;

namespace oaggoc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next();
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
