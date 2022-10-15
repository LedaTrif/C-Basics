using System;

namespace _05SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town= Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            switch (town)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        price = 0.5;
                    }
                    else if (product == "water")
                    {
                        price = 0.80;
                    }
                    else if (product == "beer")
                    {
                        price = 1.20;
                    }
                    else if (product == "sweets")
                    {
                        price = 1.45;
                    }
                    else if (product == "peanuts")
                    {
                        price = 1.60;
                    }
                    break;
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        price = 0.4;
                    }
                    else if (product == "water")
                    {
                        price = 0.70;
                    }
                    else if (product == "beer")
                    {
                        price = 1.15;
                    }
                    else if (product == "sweets")
                    {
                        price = 1.3;
                    }
                    else if (product == "peanuts")
                    {
                        price = 1.5;
                    }
                    break;
                case "Varna":
                    if (product == "coffee")
                    {
                        price = 0.45;
                    }
                    else if (product == "water")
                    {
                        price = 0.70;
                    }
                    else if (product == "beer")
                    {
                        price = 1.1;
                    }
                    else if (product == "sweets")
                    {
                        price = 1.35;
                    }
                    else if (product == "peanuts")
                    {
                        price = 1.55;
                    }
                    break;

          
            }
            

            double finalPrice = quantity * price;
            
            
                Console.WriteLine(finalPrice);
            }

        }
    }


