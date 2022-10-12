using System;

namespace _07ShoppingBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            double priceN = N * 250;
            double priceM = M*(0.35 * priceN);
            double priceP = P*(0.1 * priceN);

            double totalRealPrice = priceN + priceM + priceP;
            double discounedTotal = totalRealPrice - (0.15 * totalRealPrice);

            if (N > M)
            { 
                if (discounedTotal <= budget)
                {
                    double leftBudget = budget- discounedTotal;
                    Console.WriteLine($"You have {leftBudget:f2} leva left!");
                }
                else
                {
                    double additionalBudget = budget - discounedTotal;
                    Console.WriteLine($"Not enough money! You need {Math.Abs(additionalBudget):f2} leva more!");
                }
            }
            else
            {
                if (totalRealPrice <= budget )
                {
                    double leftBudget = budget- totalRealPrice;
                    Console.WriteLine($"You have {leftBudget:f2} leva left!");
                }
                else
                {
                    double additionalBudget = budget - totalRealPrice;
                    Console.WriteLine($"Not enough money! You need {Math.Abs(additionalBudget):f2} leva more!");
                }

            }
        }
    }
}

