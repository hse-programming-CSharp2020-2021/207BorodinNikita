using System;
using System.Linq;
class Program
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y;}
        public Point() : this(0, 0) { }
        public string PointData
        {
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
        public double Ro
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        public double Fi
        {
            get
            {
                if (X > 0)
                {
                    return Y >= 0 ? Math.Atan(Y / X) : Math.Atan(Y / X) + 2 * Math.PI;
                }

                if (X == 0)
                {
                    return Y > 0 ? 0.5 * Math.PI : (Y == 0 ? 0 : 1.5 * Math.PI);
                }
                else
                {
                    return Math.Atan(Y / X) + Math.PI;
                }
            }
        }

        public static void Info(Point point)
        {
            Console.WriteLine($"\nCoordinates: X = {point.X}, Y = {point.Y}\nFi = {point.Fi}\nRo = {point.Ro}\n");
        }

    }

    static void Delete(ref double[] array, int index)
    {
        double[] newArray = new double[array.Length];

        for (int i = 0, j = 0; i < array.Length; i++, j++)
        {
            if (i != index)
                newArray[j] = array[i];
            else
                newArray[j] = -1;
        }

        array = newArray;
    }
    static void Main()
    {
        Point a, b, c;

        a = new Point(3, 4);
        Console.WriteLine(a.PointData);

        b = new Point(0, 3);
        Console.WriteLine(b.PointData);

        c = new Point();

        double x = 0, y = 0;

        do
        {
            Console.Write("x = ");
            double.TryParse(Console.ReadLine(), out x);

            Console.Write("y = ");
            double.TryParse(Console.ReadLine(), out y);

            c.X = x; c.Y = y;

            Point[] points = { a, b, c };

            double[] pointsRo = { a.Ro, b.Ro, c.Ro };

            double[] sortedRo = pointsRo.OrderBy(item => item).ToArray();

            for (int i = 0; i < sortedRo.Length; i++)
            {
                int index = Array.FindIndex(pointsRo, item => item == sortedRo[i]);

                Point.Info(points[index]);

                Delete(ref pointsRo, index);
            }
        } while (x != 0 | y != 0);
    }
}
