using System;

namespace Task_07
{
    class Program
    {
        static void SplitOperation(double InputValue, ref int IntegerPart, ref double FrationalPart)
        {
            IntegerPart = (int)InputValue;
            FrationalPart = InputValue - IntegerPart == 0 ? 0 : InputValue - IntegerPart;
        }

        static void MathOperations(double InputValue, ref object root, ref double power)
        {
            if (InputValue >= 0)
            {
                root = Math.Sqrt(InputValue);
            }
            else
            {
                root = null;
            }

            power = Math.Pow(InputValue, 2);
        }
        static void Main(string[] args)
        {
            int IntegerPart = 0; object root = 0; double FrationalPart = 0, power = 0;

            Console.WriteLine("Введите число");

            if (!double.TryParse(Console.ReadLine(), out double InputValue))
            {
                Console.WriteLine("Ошибка!");
                return;
            }

            SplitOperation(InputValue, ref IntegerPart, ref FrationalPart);
            MathOperations(InputValue, ref root, ref power);

            Console.WriteLine("Целая часть: {0}\nДесятичная часть: {1}\nКорень из числа: {2:f3}\nКвадрат числа: {3:f3}", IntegerPart, (float)FrationalPart, root ?? "операция невозможна", power);
        }
    }
}
