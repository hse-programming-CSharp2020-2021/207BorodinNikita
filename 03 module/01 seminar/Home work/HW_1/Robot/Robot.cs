using System;

namespace Kumir
{
    public class Robot
    {
        int x, y;
        public void Right() { x++; }
        public void Left() { x--; }
        public void Forward() { y++; }
        public void Backward() { y--; }

        public string Position()
        {
            return string.Format("The Robot position: x={0}, y={1}", x, y);
        }
    }

    public delegate void Steps();
}
