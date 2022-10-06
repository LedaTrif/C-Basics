using System;

namespace E02Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //INput
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            
            // Actions

            double area = a * h / 2;
            string scalculation = area.ToString("F2");

            //Output
            Console.WriteLine(scalculation);

        }
    }
}

