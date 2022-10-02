using System;

namespace P03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double depositAmount = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interestPercentage = double.Parse(Console.ReadLine()) / 100;

            //Action
            double monthGain = (depositAmount * interestPercentage) / 12;
            double depositGain = months * monthGain;
            double totalSum = depositAmount + depositGain;

            //Output
            Console.WriteLine(totalSum);
        }
    }
}

