using System;
using System.Linq;

namespace _05_seminar
{
    class Program
    {
        static void Delete(ref int[] dataArray)
        {
            int[] newArray = new int[dataArray.Length - (Array.FindIndex(dataArray, i => i % 5 == 0) + 1)];

            for (int i = newArray.Length - 1, j = 1; i >= 0; i--, j++)
            {
                newArray[i] = dataArray[dataArray.Length - j];
            }

            dataArray = newArray;
        }

        static void NewElement(ref int[] dataArray, int newElement)
        {
            int[] newArray = new int[dataArray.Length + 1];

            for (int i = 0; i < dataArray.Length; i++)
            {
                newArray[i] = dataArray[i];
            }

            newArray[newArray.Length - 1] = newElement;

            dataArray = newArray;
        }
        static void Main(string[] args)
        {
            string check;

            int[] dataArray = { };

            do
            {
                check = Console.ReadLine();

                if (!int.TryParse(check, out int newElement) && check != "!")
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                NewElement(ref dataArray, newElement);

            } while (check != "!");

            int result = 0;

            while (dataArray.Length != 0)
            {
                result += Array.Find(dataArray, i => i % 5 == 0);

                Delete(ref dataArray);
            }

            Console.WriteLine(result);
        }
    }
}
