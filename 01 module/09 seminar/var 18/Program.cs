using System;
using System.Collections.Generic;

namespace var_18
{
    class Program
    {
        static void Generate(uint N, out double[] X, out double[] Y)
        {
            X = new double[N]; Y = new double[N];
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                X[i] = random.Next(-5, 6) + random.NextDouble();
                Y[i] = random.Next(-5, 6) + random.NextDouble();
            }
        }

        static bool HitOrMiss(double X, double Y)
        {
            int R1 = 2, R2 = 4;

            if (Math.Sqrt(X * X + Y * Y) >= R1 && Math.Sqrt(X * X + Y * Y) <= R2)
            {
                return true;
            }

            return false;
        }

        static void HitsAndMisses(double[] X, double[] Y, out List<double> Xin, out List<double> Yin, out List<double> Xout, out List<double> Yout)
        {
            Xin = new List<double>();
            Yin = new List<double>();
            Xout = new List<double>();
            Yout = new List<double>();

            for (int i = 0; i < X.Length; i++)
            {
                if (HitOrMiss(X[i], Y[i]))
                {
                    Xin.Add(X[i]);
                    Yin.Add(Y[i]);
                }
                else
                {
                    Xout.Add(X[i]);
                    Yout.Add(Y[i]);
                }
            }

            if (Xin.Count == 0)
            {
                Xin = null;
                Yin = null;
            }
            if (Xout.Count == 0)
            {
                Xout = null;
                Yout = null;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число точек:");
            if (!uint.TryParse(Console.ReadLine(), out uint N))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Generate(N, out double[] X, out double[] Y);

            HitsAndMisses(X, Y, out List<double> Xin, out List<double> Yin, out List<double> Xout, out List<double> Yout);

            Console.WriteLine("\nКоординаты попаданий:\n");
            if (Xin == null)
            {
                Console.WriteLine($"\tОстуствуют");
            }
            else
            {
                for (int i = 0; i < Xin.Count; i++)
                {
                    Console.WriteLine($"\t({Xin[i]}; {Yin[i]})");
                }
            }


            Console.WriteLine("\nКоординаты промахов:\n");
            if (Xout == null)
            {
                Console.WriteLine($"\tОстуствуют");
            }
            else
            {
                for (int i = 0; i < Xout.Count; i++)
                {
                    Console.WriteLine($"\t({Xout[i]}; {Yout[i]})");
                }
            }
        }
    }
}
