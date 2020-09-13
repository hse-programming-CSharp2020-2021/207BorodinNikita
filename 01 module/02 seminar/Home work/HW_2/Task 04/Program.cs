using System;

namespace Task_04
{
    class Program
    {
        static void Reverse(int InputNumber)
        {
            byte[] Digits = new byte[4];

            for (int i = Digits.Length - 1; i >= 0; i--)
            {
                Digits[i] = (byte)(InputNumber % 10);
                InputNumber = (InputNumber - Digits[i]) / 10;
            }

            Console.WriteLine($"Результат перестановки = {Digits[3]}{Digits[2]}{Digits[1]}{Digits[0]}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное четырёхзначное число");

            if (!ushort.TryParse(Console.ReadLine(), out ushort InputNumber) || InputNumber > 9999 || InputNumber < 1000)
            {
                Console.WriteLine("Ошибка!");
                return;
            }

            Reverse(InputNumber);
        }
    }
}
