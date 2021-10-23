using System;

namespace Задание_3
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("введите занчение х");
            var x = double.Parse(Console.ReadLine());
            double y = 2 / A(x) + Math.Cos(x);
            Console.WriteLine(y);
            double z = y / B(x);
            Console.WriteLine(z);
        }
        static double A(double x)
        {
            return (x * x + 25);
        }
        static double B(double x)
        {
            return Math.Sqrt(x * x * x * x + 1) + (Math.Cos(x) + Nath.Sin(x)) / 2;
        }
    }

}
