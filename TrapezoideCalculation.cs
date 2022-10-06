using System;

namespace E01Trapezoide
{
    class Program
    {
        static void Main(string[] args)
        {
            //INput
           double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            // Actions

            double calculation = (b1 + b2) * h / 2;
            string scalculation = calculation.ToString("F2");

            //Output
            Console.WriteLine(scalculation);

        }
    }
}

