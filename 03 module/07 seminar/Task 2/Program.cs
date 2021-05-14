using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];

            for (int index = 0; index < numbers.Length; index++)
                numbers[index] = random.Next();

            string data = string.Join('\n', numbers);

            string path1 = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Task 2.1.txt");

            using (FileStream stream = File.Open(path1, FileMode.OpenOrCreate))
            {
                stream.Write(Encoding.Default.GetBytes(data), 0, Encoding.Default.GetByteCount(data));
            }

            string path2 = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Task 2.2.txt");

            using (StreamWriter writer = new StreamWriter(path2, true))
            {
                writer.Write(data);
            }

            string path3 = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Task 2.3.txt");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path3, FileMode.OpenOrCreate)))
            {
                writer.Write(data);
            }

            using (FileStream stream = File.OpenRead(path1))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                Console.WriteLine(Encoding.Default.GetString(buffer));
            }

            using (StreamReader reader = new StreamReader(File.OpenRead(path2)))
            {
                int oddRes = new int();
                string val;

                while (reader.BaseStream.Position < reader.BaseStream.Length)
                    if (Convert.ToInt32(val = reader.ReadLine()) % 2 == 0)
                        oddRes += Convert.ToInt32(val);

                Console.WriteLine(oddRes);
            }
        }
    }
}
