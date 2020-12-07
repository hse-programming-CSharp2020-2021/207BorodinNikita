using System;
using MyLib;

namespace Task_1
{
    class Program
    {
        static void WriteMatrix(Matrix matrix)
        {
            for (int row = 0; row < matrix.Width; row++)
            {
                for (int column = 0; column < matrix.Height; column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }
                Console.WriteLine();
            }
        }

        static void CreateIdentity(int N, out Matrix matrix)
        {
            matrix = new Matrix(N, N);

            for (int row = 0; row < matrix.Width; row++)
            {
                for (int column = 0; column < matrix.Height; column++)
                {
                    matrix[row, column] = row == column ? 1 : 0;
                }
            }
        }

        static void Main()
        {
            do
            {
                Console.Clear();

                try
                {
                    int N = int.Parse(Console.ReadLine());

                    CreateIdentity(N, out Matrix matrix);
                    WriteMatrix(matrix);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"\nFormat error: {ex.Message}");
                }
                catch(ArgumentNullException ex)
                {
                    Console.WriteLine($"\nNull error: { ex.Message}");
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"\nArgument error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine($"\nTo quit press ESC, to continue - other key.");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
