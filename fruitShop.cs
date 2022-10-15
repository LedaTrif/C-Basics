using System;
namespace _11FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double priceofFruit = 0;

            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            priceofFruit = 2.50;
                            break;
                        case "apple":
                            priceofFruit = 1.2;
                            break;
                        case "orange":
                            priceofFruit = 0.85;
                            break;
                        case "grapefruit":
                            priceofFruit = 1.45;
                            break;
                        case "kiwi":
                            priceofFruit = 2.70;
                            break;
                        case "pineapple":
                            priceofFruit = 5.50;
                            break;
                        case "grapes":
                            priceofFruit = 3.85;

                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }

                    break;

                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            priceofFruit = 2.70;
                            break;
                        case "apple":
                            priceofFruit = 1.25;
                            break;
                        case "orange":
                            priceofFruit = 0.9;
                            break;
                        case "grapefruit":
                            priceofFruit = 1.6;
                            break;
                        case "kiwi":
                            priceofFruit = 3;
                            break;
                        case "pineapple":
                            priceofFruit = 5.6;
                            break;
                        case "grapes":
                            priceofFruit = 4.2;

                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

            double finalPrice = quantity * priceofFruit;
            if (finalPrice > 0)
            {
                Console.WriteLine($"{finalPrice:F2}");
            }
        }
    }
}