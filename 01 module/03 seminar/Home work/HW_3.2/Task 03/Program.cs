using System;

namespace Test_03
{
    class Program
    {
        static double MyMethod(double X)
        {
            if (X > 0.5)
                return Math.Sin(Math.PI * (X - 1) / 2);
            else
                return Math.Sin(Math.PI / 2);
        }
        static void Main(string[] args)
        {
            if(!double.TryParse(Console.ReadLine(), out double X))
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine("G = {0:F3}", MyMethod(X));
        }
    }
}
