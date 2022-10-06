using System;

namespace E03cToF
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());

            double F = (C * 9) / 5 + 32;
            string sF = F.ToString("F2");

            Console.WriteLine(sF);
        }
    }
}

