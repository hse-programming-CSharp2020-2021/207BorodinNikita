using System;


namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstCathetus = double.Parse(Console.ReadLine());

            double SecondCathetus = double.Parse(Console.ReadLine());

            if ( FirstCathetus > 0 && SecondCathetus > 0)
            {
                double Hypotenuse = Math.Sqrt(FirstCathetus * FirstCathetus + SecondCathetus * SecondCathetus);
                Console.WriteLine(Hypotenuse);
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}
