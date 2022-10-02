using System;

namespace P07RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input

            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());


            //Actions
            double priceChickenMenus = chickenMenus * 10.35;
            double priceFishMenus = fishMenus * 12.40;
            double priceVegetarianMenus = vegetarianMenus * 8.15;
            double main = priceChickenMenus + priceFishMenus + priceVegetarianMenus;
            double dessert = main * 0.20;
            double orderPrice = main + dessert; 
            double totalPrice = orderPrice + 2.50;

            //Output

            Console.WriteLine(totalPrice);

        }
    }
}

