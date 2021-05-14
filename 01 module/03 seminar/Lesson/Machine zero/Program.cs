using System;

namespace Machine_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            float NewResult = 0, OldResult = 1;

            for (int i = 0; OldResult - NewResult != 0; i++)
            {
                OldResult = NewResult;

                NewResult += 1 / ((float)i * (i + 1) * (i + 2));
            }

            Console.WriteLine(OldResult);
            Console.WriteLine(NewResult);
        }
    }
}
