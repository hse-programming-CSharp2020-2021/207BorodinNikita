using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01_1
{
    class A
    {
        public virtual void GetA()
        {
            Console.WriteLine("This is type A.");
        }
    }

    class B : A
    {
        public override void GetA()
        {
            Console.WriteLine("This is type B.");
        }
    }
}
