using System;

namespace Е08CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double s = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            string s2 = s.ToString("F2");
            string p2 = perimeter.ToString("F2");

            Console.WriteLine($"{s2}");
            Console.WriteLine($"{p2}");

        }
    }
}

