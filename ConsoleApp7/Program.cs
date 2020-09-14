using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double S, c, P;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            c = Math.Sqrt(x * x + y * y);
            P = x + y + c;
            S = x * y * 0.5;
            Console.WriteLine("гипотенуза = " + c);
            Console.WriteLine("площадь = " + S);
            Console.WriteLine("периметр = " + P);
            Console.ReadKey();
        }
    }
}
