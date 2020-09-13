using System;

namespace Task_03
{
    class Program
    {
        static void Equation(double A, double B, double C)
        {
            double Discriminant = A == 0 ? -1 : B * B - 4 * A * C;

            string result = Discriminant < 0 && A == 0 ? ("x = {" + (-C / B).ToString("F3") + "}") :

                (Discriminant < 0 ? "Корней нет" :

                (Discriminant == 0 ? "x = {" + (-B / 2 * A).ToString("F3") + "}" :

                "x = {" + ((-B - Math.Sqrt(Discriminant)) / 2 * A).ToString("F3") + ", " + ((-B + Math.Sqrt(Discriminant)) / 2 * A).ToString("F3") + "}"));

            Console.WriteLine();
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите коэффициенты квадратного уравнения в строку через пробел");

                string[] input = Console.ReadLine().Split();

                double A = double.Parse(input[0]);

                double B = double.Parse(input[1]);

                double C = double.Parse(input[2]);

                Equation(A, B, C);

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}
