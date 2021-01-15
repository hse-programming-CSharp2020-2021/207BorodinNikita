using System;

class Program
{
    static void Main()
    {
        int x = 1;
        float y = 1.1f;
        short z = 1;
        Console.WriteLine((float)x + y * z - (x += (short)y));
    }
}

