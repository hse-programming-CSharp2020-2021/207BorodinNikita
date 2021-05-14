using System;

public delegate void MethodsEvents();
public delegate void ItemEvents(int[,] ar);

public class Methods
{
    public static event MethodsEvents LineComplete;

    public static event ItemEvents NewItemFilled;

    public static void ArrayPrint(int[,] arr)
    {
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                Console.Write(arr[i, j] + " ");
            LineComplete();
        }
    }

    public static void ArrayFill(int[,] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                arr[i, j] = rnd.Next(100); 
                NewItemFilled?.Invoke(arr);
            }
    }

    public static void ArraySumCount(int[,] arr)
    {
        int sum = 0;

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                sum += arr[i, j];
        }

        Console.WriteLine(sum);
    }

    public static void GetAverage(int[,] arr)
    {
        int sum = 0;

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                sum += arr[i, j];
        }

        Console.WriteLine(sum / arr.Length);
    }

    public static void ChangeMax(int[,] arr)
    {
        Random rnd = new Random();

        int max = 0;

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                if (arr[i, j] > max)
                    max = arr[i, j];
        }

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                if (arr[i, j] == max)
                    arr[i, j] = rnd.Next(100);
        }
    }
}

class Program
{
    static void Main()
    {
        int[,] arr = new int[15, 15];
        int x = 0;

        Methods.NewItemFilled += Methods.ArraySumCount;
        Methods.NewItemFilled += Methods.GetAverage;
        Methods.NewItemFilled += Methods.ChangeMax;

        Methods.LineComplete += () => { Console.WriteLine(); };

        Methods.ArrayFill(arr);
        Methods.ArrayPrint(arr);
    }
}
