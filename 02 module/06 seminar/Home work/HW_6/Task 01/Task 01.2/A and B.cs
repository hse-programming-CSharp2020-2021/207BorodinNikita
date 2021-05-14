using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01_2
{
    class A
    {
        public void GetA()
        {
            Console.WriteLine("This is type A.");
        }
    }

    class B : A
    {
        new public void GetA()
        {
            Console.WriteLine("This is type B.");
        }
    }
}
