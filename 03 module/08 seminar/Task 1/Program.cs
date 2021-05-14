// Проект 2. Чтение целых из двоичного потока. 
// ЧИТАТЬ И ЗАПИСЫВАТЬ СТРОГО ПО ОДНОМУ ЧИСЛУ!!! 
using System;
using System.IO;
class Program
{
    static void Main()
    {

        BinaryWriter fOut = new BinaryWriter(

            new FileStream("../../../t.dat", FileMode.Create));

        for (int i = 0; i <= 10; i += 2)

            fOut.Write(i);

        fOut.Close();

        FileStream f = new FileStream("../../../t.dat", FileMode.Open);
        BinaryReader fIn = new BinaryReader(f);
        long n = f.Length / 4; int a;
        for (int i = 0; i < n; i++)
        {
            a = fIn.ReadInt32();
            Console.Write(a + " ");
        }
        Console.WriteLine("\nЧисла в обратном порядке:");
        // 1) TODO: Прочитать и напечатать все числа из файла в обратном порядке
        // 2) TODO: увеличить  все числа в файле в 5 раз
        // 3) TODO: Прочитать и напечатать все числа из файла в прямом порядке
        fIn.Close();
        f.Close();

        using (FileStream fStream = new FileStream("../../../t.dat", FileMode.Open))
        {
            using (BinaryReader writer = new BinaryReader(fStream))
            {
                for (int offset = 4; offset <= writer.BaseStream.Length; offset += 4)
                {
                    writer.BaseStream.Seek(-offset, SeekOrigin.End);
                    Console.WriteLine(writer.ReadInt32());
                }
            }
        }

        using (FileStream fStream = new FileStream("../../../t.dat", FileMode.Open))
        {
            using (BinaryWriter writer = new BinaryWriter(fStream))
            {
                using (BinaryReader reader = new BinaryReader(fStream))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int value = reader.ReadInt32() * 5;
                        fStream.Position -= 4;

                        writer.Write(value);
                    }
                }
            }
        }

        using (FileStream fStream = new FileStream("../../../t.dat", FileMode.Open))
        {
            using (BinaryReader reader = new BinaryReader(fStream))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    Console.WriteLine(reader.ReadInt32());
                }
            }
        }
    }
}