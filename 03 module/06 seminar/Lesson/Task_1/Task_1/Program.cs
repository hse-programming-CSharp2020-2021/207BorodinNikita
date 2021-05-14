using System;

namespace Task_1
{
    interface ICalculation
    {
        abstract double Perform(double value);
    }

    class Add : ICalculation
    {
        public double Value { get; set; }

        public double Perform(double value)
        {
            return value + Value;
        }

        public Add(double value)
        {
            Value = value;
        }
    }

    class Multiply : ICalculation
    {
        public double Value { get; set; }

        public double Perform(double value)
        {
            return value * Value;
        }

        public Multiply(double value)
        {
            Value = value;
        }
    }

    class Program
    {
        static double Calculate(double value, ICalculation first, ICalculation second)
        {
            return second.Perform(first.Perform(value));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(1, new Add(2), new Multiply(3)));
        }
    }
}
