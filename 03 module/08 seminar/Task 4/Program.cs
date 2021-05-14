using System;

namespace Task_4
{
    struct Rectangle : IComparable
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area => Width * Height;

        public int CompareTo(object obj)
        {
            Rectangle other = (Rectangle)obj;

            if (Area < other.Area)
                return -1;

            else if (Area == other.Area)
                return 0;

            else return 1;
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"rectangle with area {Area}";
        }
    }

    class Block3D : IComparable
    {
        public Rectangle Base { get; set; }

        public int CompareTo(object obj)
        {
            return Base.CompareTo(((Block3D)obj).Base);
        }

        public Block3D(Rectangle rectBase)
        {
            Base = rectBase;
        }

        public override string ToString()
        {
            return $"Block with base: {Base}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Block3D[] blocks = new Block3D[10];

            for (int index = 0; index < blocks.Length; index++)
            {
                double width = random.Next(0, 10) + random.NextDouble();
                double length = random.Next(0, 10) + random.NextDouble();

                blocks[index] = new Block3D(new Rectangle(width, length));
            }

            Array.Sort(blocks, (block1, block2) => block1.CompareTo(block2));

            foreach (var block in blocks)
                Console.WriteLine(block);
        }
    }
}
