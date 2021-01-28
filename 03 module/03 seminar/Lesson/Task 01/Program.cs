using System;

namespace Task_01
{
    delegate void SquareSizedChanged(double side);

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Square
    {
        public event SquareSizedChanged OnSizeChanged;

        Point point1;
        Point point2;

        public Point UpLeft
        {
            get
            {
                return point1;
            }
            set
            {
                OnSizeChanged?.Invoke(value.X - point1.X);

                point1 = value;
            }
        }
        public Point DownRight
        {
            get
            {
                return point2;
            }
            set
            {
                OnSizeChanged?.Invoke(value.X - point1.X);

                point2 = value;
            }
        }

        public Square(int x1, int y1, int x2, int y2)
        {
            point1 = new Point(x1, y1);
            point2 = new Point(x2, y2);
        }
    }
    class Program
    {
        static void SquareConsoleInfo(double A)
        {
            Console.WriteLine($"{A:F2}");
        }

        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();

            int x1 = Convert.ToInt32(values[0]);
            int y1 = Convert.ToInt32(values[1]);
            int x2 = Convert.ToInt32(values[2]);
            int y2 = Convert.ToInt32(values[3]);

            Square S = new Square(x1, y1, x2, y2);

            S.OnSizeChanged += SquareConsoleInfo;

            try
            {
                while (true)
                {
                    string[] newValues = Console.ReadLine().Split();

                    S.DownRight = new Point(Convert.ToInt32(newValues[0]), Convert.ToInt32(newValues[1]));
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
