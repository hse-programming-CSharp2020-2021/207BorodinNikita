using System;
using System.Linq;

namespace Task_02
{
    class Program
    {
        static void MaxNumber(int InputNumber)
        {
            byte[] Digits = new byte[3];

            for (int i = Digits.Length - 1; i >= 0; i--)
            {
                Digits[i] = (byte)(InputNumber % 10);
                InputNumber = (InputNumber - Digits[i]) / 10;
            }

            Digits = Digits.OrderByDescending(i => i).ToArray();

            Console.WriteLine($"Наибольшее число = {Digits[0]}{Digits[1]}{Digits[2]}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное трёхзначное число");

            if (!ushort.TryParse(Console.ReadLine(), out ushort InputNumber) || InputNumber > 999 || InputNumber < 100)
            {
                Console.WriteLine("Ошибка!");
                return;
            }

            MaxNumber(InputNumber);

            Console.ReadLine();
        }
    }
}
