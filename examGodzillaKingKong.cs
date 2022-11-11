using System;

namespace I02GodzillaVsKingKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            int statist=int.Parse(Console.ReadLine());
            double clothes= double.Parse(Console.ReadLine());
            double clothesTotal = 0;
            double totalCost = 0;

            //10% of budget 
            double decor = budget * 0.1;
            //if statist>150--->clothes-=clothes*0.1;

            if(statist>150)
            {
                clothes -= clothes * 0.1;
               

            }
            clothesTotal = statist * clothes;
            totalCost = decor + clothesTotal;
           
            //Output budget is enough?
            if(budget<totalCost)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {(totalCost-budget):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budget-totalCost):f2} leva left.");

            }
        }
    }
}

