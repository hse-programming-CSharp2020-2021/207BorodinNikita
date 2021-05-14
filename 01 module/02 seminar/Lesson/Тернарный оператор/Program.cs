using System;

namespace Тернарный_оператор
{
    class Program
    {
        static void Main(string[] args)
        {
           byte symbol = byte.Parse(Console.ReadLine());
           string result = 48 <= symbol && symbol <= 57 ? "Это цифра" : 65 <= symbol && symbol <= 90 || 97 <= symbol && symbol <= 122 ? "Это символ" : "Это не символ и не цифра";

           Console.WriteLine(result);
        }
    }
}
