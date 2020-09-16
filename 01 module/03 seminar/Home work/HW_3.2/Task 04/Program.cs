using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Num = new int[3];


            for (int i = 0; i < Num.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out Num[i]))
                {
                    Console.WriteLine("Error");
                    return;
                }
            }

            int result = Num[0] % 100 < Num[1] % 100 ? (Num[0] % 100 < Num[2] % 100 ? Num[0] : Num[2]) :
                (Num[1] % 100 < Num[2] % 100 ? Num[1] : Num[2]);

            Console.WriteLine(result);
        }
    }
}
