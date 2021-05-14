using System;

namespace Task_02
{
    class Program
    {
        delegate int[] MyDelegate1(int n);

        delegate void MyDelegate2(int[] array);

        static int[] Foo1(int n)
        {
            int[] result = new int[(int)Math.Log10(n) + 1];

            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = n % 10;
                n = (n - n % 10) / 10;
            }

            return result;
        }

        static void Foo2(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }

        static void Main(string[] args)
        {
            int n = new Random().Next(10000, 100000);
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10, 100);
            }

            MyDelegate1 delegate1 = new MyDelegate1(Foo1);
            MyDelegate2 delegate2 = new MyDelegate2(Foo2);

            delegate2.Invoke(delegate1.Invoke(n));
            Console.WriteLine();
            delegate2.Invoke(array);
            Console.WriteLine();

            Console.WriteLine($"Target: {delegate1.Target}; Method: {delegate1.Method}");
            Console.WriteLine($"Target: {delegate2.Target}; Method: {delegate2.Method}");
        }
    }
}
