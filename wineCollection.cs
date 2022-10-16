using System;

namespace _03WineProduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int m2 = int.Parse(Console.ReadLine());
            double grapesM2= double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workersCnt= int.Parse(Console.ReadLine());


            double kgGrapesCollectedForWine = grapesM2 * (0.4 * m2);
            double wineProduced = kgGrapesCollectedForWine / 2.5;

            if(wineProduced<wineNeeded)
            {
                double wineLess = wineNeeded - wineProduced;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLess)} liters wine needed.");
            }
            else if(wineProduced>=wineNeeded)
            {
                double wineMore = wineProduced - wineNeeded;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
                double winePerWorker = wineMore / workersCnt;
                Console.WriteLine($"{Math.Ceiling(wineMore)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");

            }
        }
    }
}

