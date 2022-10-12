using System;

namespace _05MovieBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input//
            double budget = double.Parse(Console.ReadLine());
            int actorsNum= int.Parse(Console.ReadLine());
            double costumePriceUnits= double.Parse(Console.ReadLine());


            //ACtions//
            double totalCostumesPrice = actorsNum * costumePriceUnits;
            double decorPrice = 0.10 * budget;
            double expenses = totalCostumesPrice + decorPrice;
            double amountNeeded = budget - expenses;

          if(actorsNum>150)
            {
                double expensesDiscounted = (totalCostumesPrice-(0.1*totalCostumesPrice)) + decorPrice;
                double amountLeft = budget - expensesDiscounted;
                if (expenses > budget)
                {
                    Console.WriteLine($"Not enough money!");
                    Console.WriteLine($"Wingard needs {Math.Abs(amountLeft):f2} leva more.");
                }
                else if (expenses <= budget)
                {
                    Console.WriteLine($"Action!");
                    Console.WriteLine($"Wingard starts filming with {amountLeft:f2} leva left.");
                }

            }
            else if (expenses>budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(amountNeeded):f2} leva more.");
            }
            else if(expenses<=budget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {amountNeeded:f2} leva left.");
            }

        }
    }
}

