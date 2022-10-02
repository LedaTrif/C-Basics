using System;

namespace P02RadiansToGradusi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double radians = double.Parse(Console.ReadLine());


            //Actions
            double degrees = (radians * 180) / Math.PI;

            //Output
            Console.WriteLine(degrees);
        }
    }
}

