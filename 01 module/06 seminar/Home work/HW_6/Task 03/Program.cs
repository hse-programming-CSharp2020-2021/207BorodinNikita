using System;

namespace Task_3._1
{
    class Program
    {
        static double[] Sin1(uint N)
        {
            double[] elements = new double[N];

            for (int i = 0, j = 1; i < elements.Length; i++, j += 2)
            {
                double factorial = 1;
                for (int k = 1; k <= j; k++)
                {
                    factorial *= k; 
                }

                elements[i] = (Math.Pow(-1, i) * 1) / factorial;
            }
            return elements;
        }
        static double? Sin(double x, double[] elements)
        {
            double result = 0;

            for (int i = 0, j = 1; i < elements.Length; i++, j += 2)
            {
                if (result == result + elements[i] * Math.Pow(x, j))
                {
                    return result;
                }
                double n = elements[i] * Math.Pow(x, j);

                result += n;
            }

            return result;
        }
        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint N))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            double[] elements = Sin1(N);

            while (true)
            {
                if(!double.TryParse(Console.ReadLine(), out double angle))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                double x = angle % (Math.PI * 2);

                Console.WriteLine($"Sin() result: {Sin(x, elements)}\nMath.Sin() result: {Math.Sin(angle)}\n");
            }
        }
    }
}
