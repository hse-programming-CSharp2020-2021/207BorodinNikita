using System;

namespace Task_01
{
    class Program
    {
        delegate int Cast(double value);
        static void Main(string[] args)
        {
            Random random = new Random();

            Cast oddCast = delegate (double value)
            {
                int number = (int)value;
                return number % 2 == 0 ? number : number > 0 ? number + 1 : number - 1;
            };

            Cast orderCast = delegate (double value)
            {
                return (int)Math.Log10((int)value) - 1;
            };

            Console.WriteLine(oddCast(random.Next() + random.NextDouble()));
            Console.WriteLine(orderCast(random.Next() + random.NextDouble()));

            Cast lambdaOddCast = value => (int)value % 2 == 0 ? (int)value : (int)value > 0 ? (int)value + 1 : (int)value - 1;
            Cast lambdaOrderCast = value => (int)Math.Log10((int)value) - 1;

            Console.WriteLine(lambdaOddCast(random.Next() + random.NextDouble()));
            Console.WriteLine(lambdaOrderCast(random.Next() + random.NextDouble()));

            Cast mixCast = oddCast + orderCast;

            Console.WriteLine(mixCast(random.Next() + random.NextDouble()));
        }
    }
}
