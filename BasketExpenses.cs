using System;

namespace P08BasketballExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double yearlyTaxBasketball = double.Parse(Console.ReadLine());

            double shoes = yearlyTaxBasketball - (yearlyTaxBasketball * 0.40);
            double clothes = shoes - (shoes * 0.20);
            double ball = clothes / 4;
            double accessories = ball / 5;

            double totalExpenses = yearlyTaxBasketball + shoes + clothes + ball + accessories;


            Console.WriteLine(totalExpenses);
        }
    }
}

