using System;

namespace _04ToysIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input: add TourPrice and number of sold toys per types//
            double tourPrice = double.Parse(Console.ReadLine());
            int puzzleNum = int.Parse(Console.ReadLine());
            int dollsNum = int.Parse(Console.ReadLine());
            int bearsNum = int.Parse(Console.ReadLine());
            int minionsNum = int.Parse(Console.ReadLine());
            int trucksNum = int.Parse(Console.ReadLine());

            //Actions//
            int totalToysNum = puzzleNum + dollsNum + bearsNum + minionsNum + trucksNum;
            double income = puzzleNum * 2.60 + dollsNum * 3 + bearsNum * 4.10 + minionsNum * 8.20 + trucksNum * 2;

            if (totalToysNum >= 50)
            {
                double discount = 0.25 * income;
                double totalIncome = income - discount;
                double rent = 0.10 * totalIncome;
                double revenue = totalIncome - rent;
                double amountLeft = revenue - tourPrice;
                if (revenue >= tourPrice)
                {
                    Console.WriteLine($"Yes! {amountLeft:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {amountLeft:f2} lv needed.");
                }
            }
            else
            {
                double revenue = income - 0.1 * income;
                double amountLeft = revenue - tourPrice;

                if (revenue >= tourPrice)
                {
                    Console.WriteLine($"Yes! {Math.Abs(amountLeft):f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Math.Abs(amountLeft):f2} lv needed.");
                }
            }

        }
    }
}
            