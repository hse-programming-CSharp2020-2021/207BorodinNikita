using System;

namespace Task_1
{
    delegate string ConvertRule(string str);

    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }
    class Program
    {
        public static string RemoveDigits(string str)
        {
            for(var i = 0; i < str.Length; i++)
            {
                if (int.TryParse(str[i].ToString(), out int digit))
                {
                    str = str.Remove(i, 1);
                    i--;
                }
            }

            return str;
        }

        public static string RemoveSpaces(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    str = str.Remove(i, 1);
                    i--;
                }
            }

            return str;
        }

        static void Main(string[] args)
        {
            string[] testStrings =
            {
                "abcd123fi5g 8k2973'$",
                "   kefi 48524 dkfgigf 24574 s3 31!",
                "I'm                  John",
            };

            Converter converter = new Converter();

            foreach (var item in testStrings)
            {
                Console.WriteLine(converter.Convert(item, RemoveDigits));
            }

            Console.WriteLine();

            foreach (var item in testStrings)
            {
                Console.WriteLine(converter.Convert(item, RemoveSpaces));
            }

            Console.WriteLine();

            ConvertRule myDel = RemoveDigits;
            myDel += RemoveSpaces;

            foreach (var item in testStrings)
            {
                Console.WriteLine(converter.Convert(item, myDel));
            }

            Console.WriteLine();
        }
    }
}
