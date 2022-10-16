using System;

namespace _05Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOut = int.Parse(Console.ReadLine());
            int foodAvailable = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDayGrams = double.Parse(Console.ReadLine());

            double totalFoodNeededPerDay = dogFoodPerDay + catFoodPerDay + (turtleFoodPerDayGrams/1000);

     
            double totalFoodNeeded = totalFoodNeededPerDay * daysOut;

            if (totalFoodNeeded<=foodAvailable)
            {
                double foodLeft = foodAvailable - (totalFoodNeededPerDay*daysOut);

                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodMore = (totalFoodNeededPerDay*daysOut) - foodAvailable;

                Console.WriteLine($"{Math.Ceiling(foodMore)} more kilos of food are needed.");
            }
        }
    }
}

