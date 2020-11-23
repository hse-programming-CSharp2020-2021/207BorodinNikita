using System;
using Figures;

namespace Task_02
{
    class Program
    {
        public static Point[] FigArray()
        {
            Random random = new Random();

            Point[] figures = new Point[random.Next(0, 21)];

            for (int index = 0, circlesCount = 0; index < figures.Length; index++)
            {
                if (random.Next(0, 2) == 0 && circlesCount <= 10)
                    figures[index] = new Circle(random.Next(10, 100) + random.NextDouble(), random.Next(10, 100) + random.NextDouble(), random.Next(10, 100) + random.NextDouble());
                else
                    figures[index] = new Square(random.Next(10, 100) + random.NextDouble(), random.Next(10, 100) + random.NextDouble(), random.Next(10, 100) + random.NextDouble());
            }

            return figures;
        }
        static void Main(string[] args)
        {
            Point[] figures = FigArray();

            int circlesCount = 0, squaresCount = 0;

            double circleAreaSum = 0, circlePerimeterSum = 0;
            double squareAreaSum = 0, squarePerimeterSum = 0;

            foreach (var figure in figures)
            {
                if (figure is Circle)
                {
                    circleAreaSum += ((Circle)figure).Area;
                    circlePerimeterSum += ((Circle)figure).Len;

                    circlesCount++;
                }
                else
                {
                    squareAreaSum += ((Square)figure).Area;
                    squarePerimeterSum += ((Square)figure).Len;

                    squaresCount++;
                }
            }

            Console.WriteLine($"Circles count = {circlesCount}{Environment.NewLine}" +
                $"\taverage area = {circleAreaSum / circlesCount}; average perimeter = {circlePerimeterSum / circlesCount};");

            Console.WriteLine($"Squares count = {squaresCount}{Environment.NewLine}" +
                 $"\taverage area = {squareAreaSum / squaresCount}; average perimeter = {squarePerimeterSum / squaresCount};");

            Console.WriteLine("\nBase array:");
            foreach (var figure in figures)
            {
                Console.WriteLine();
                figure.Display();
                Console.WriteLine();
            }

            Array.Sort(figures, (item1, item2) => item1.Area.CompareTo(item2.Area));

            Console.WriteLine("Sorted array:");
            foreach (var figure in figures)
            {
                Console.WriteLine();
                figure.Display();
                Console.WriteLine();
            }
        }
    }
}
