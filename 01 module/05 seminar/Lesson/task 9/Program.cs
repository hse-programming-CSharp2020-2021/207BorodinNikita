using System;
using System.Linq;

namespace task_9
{
    class Program
    {
        static void DeleteToIndex(ref int[] array, int[] a)
        {
            int newLength = (array.Length - 1) - Array.FindIndex();

            int[] newArray = new int[newLength];
        }
        static void NewElement(ref int[] array, int newElement)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[newArray.Length - 1] = newElement;

            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] a = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < a.Length; i++)
            {
               a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите значение для замены");
            int replace = int.Parse(Console.ReadLine());

            int[] b = a; int[] c = { };

            for (int j = 0; b.Length != 0;  j++)
            {
                NewElement(ref c, Array.FindIndex(b, i => i == a.Max()));

                DeleteToIndex(ref b, a);
            }

            for (int i = 0; i < c.Length; i++)
            {
                a[c[i]] = replace;
            }

            foreach (var item in a)
            {
                Console.WriteLine(item + "\t");
            }
        }
    }
}
