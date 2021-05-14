using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = string.Empty;

            using (var stream = File.OpenRead(@"..\..\..\Program.cs"))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                string text = System.Text.Encoding.Default.GetString(buffer);

                foreach (var item in text)
                    if (item >= '0' && item <= '9')
                        output += item;
            }

            Console.WriteLine(output);
        }
    }
}
