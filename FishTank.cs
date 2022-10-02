using System;

namespace P09AquariumLiters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int lenghtCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double lossPercent = double.Parse(Console.ReadLine()) / 100;

            //Action
            // Volume = a * b * c (int*int * int=int)

            int volumeCm3 = lenghtCm * widthCm * heightCm;
            double volumeLiters = volumeCm3 / 1000.00;
            double lossLiters = volumeLiters * lossPercent;

            double totalLiters = volumeLiters - lossLiters;

            //Output

            Console.WriteLine(totalLiters);
        }
    }
}

