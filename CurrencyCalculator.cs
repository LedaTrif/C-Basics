using System;

namespace P01.CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double usd = double.Parse(Console.ReadLine());


            //Actions
            double bgn = usd * 1.79549;


            //Output
            Console.WriteLine(bgn);

        }
    }
}

