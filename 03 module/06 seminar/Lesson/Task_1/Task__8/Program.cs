using System;

namespace Task__8
{
    interface ISequance
    {
        double GetElement(int index);
    }

    class ArithmeticProgression : ISequance
    {
        double First { get; set; }
        double Delta { get; set; }

        public double GetElement(int index)
        {
            return First + Delta * index;
        }

        public ArithmeticProgression(double first, double delta)
        {
            First = first;
            Delta = delta;
        }
    }

    class GeometricProgression : ISequance
    {
        double First { get; set; }
        double Multiplier { get; set; }

        public double GetElement(int index)
        {
            return First * Math.Pow(Multiplier, index);
        }

        public GeometricProgression(double first, double multiplier)
        {
            First = first;
            Multiplier = multiplier;
        }
    }
    class Program
    {
        static double Sum(ISequance sequance, int count)
        {
            double result = 0;

            for (int index = 0; index < count; index++)
                result += sequance.GetElement(index);

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new ArithmeticProgression(3, 5), 10));
            Console.WriteLine(Sum(new GeometricProgression(3, 5), 10));
        }
    }
}
