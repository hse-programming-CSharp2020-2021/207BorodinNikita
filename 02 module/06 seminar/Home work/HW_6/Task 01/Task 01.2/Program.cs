using System;

namespace Task_01_2
{
    class Program
    {
        // Экранирование.
        static void Main(string[] args)
        {
            A[] arr = new A[10];

            Random ran = new Random();
            for (int k = 0; k < arr.Length; k++)
            {
                if (ran.Next(0, 3) % 2 == 0) arr[k] = new A();
                else
                    arr[k] = new B();
            }

            foreach (var d in arr)
            {
                d.GetA();
            }

            Console.WriteLine("\nОбъекты класса B:\n");

            foreach (var d in arr)
            {
                if (d is B)
                    d.GetA();
            }

            Console.WriteLine("\nОбъекты класса A:\n");

            foreach (var d in arr)
            {
                if (d is A)
                    d.GetA();
            }
        }
    }
}
