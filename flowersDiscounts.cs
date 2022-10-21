using System;

namespace ME3Flowers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrizantemas = int.Parse(Console.ReadLine());
            int roses= int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double price = 0.00;
            double flowers = chrizantemas + roses + tulips;
            double flowersPriceSummerSpring = (chrizantemas * 2) + (roses * 4.1) + (tulips * 2.5);
            double flowersPriceAutumnWinter= (chrizantemas * 3.75) + (roses * 4.5) + (tulips * 4.15);
            double serviceFee = 2.00;


            switch (holiday)
            {
                case "Y":
                    {
                        if ((tulips >= 7 && season == "Summer") || (tulips >= 7 && season == "Spring"))
                        {
                            price = (flowersPriceSummerSpring * 1.15) * 0.95;
                        }
                        else
                        {
                            price = flowersPriceSummerSpring * 1.15;
                        }
                        if (roses >= 10 && season == "Winter")
                        {
                            price = (flowersPriceAutumnWinter * 1.15) * 0.9;
                        }

                        else if (season == "Autumn" || season == "Winter")
                        {
                            price = flowersPriceAutumnWinter * 1.15;
                        }
                    }
                    break;


                case "N":       
                    {
                        if ((tulips >= 7 && season == "Summer") || (tulips >= 7 && season == "Spring"))
                        {
                            price = flowersPriceSummerSpring * 0.95;
                        }
                        else if(season=="Spring" || season=="Summer")
                        {
                            price = flowersPriceSummerSpring;
                        }
                        if (roses >= 10 && season == "Winter")
                        {
                            price = flowersPriceAutumnWinter * 0.9;
                        }
                        else if (season == "Winter" || season == "Autumn")
                            price = flowersPriceAutumnWinter;
                    }
                    break;
            }

            if(flowers>=20)
            {
                price *= 0.80;
                Console.WriteLine($"{(price+serviceFee):F2}");
            }
            else
            {
                Console.WriteLine($"{(price+serviceFee):F2}");
            }


        }
    }
}

