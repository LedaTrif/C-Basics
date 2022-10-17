using System;

namespace _02SummerClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            if (dayTime == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    string outfit = "Sweatshirt";
                    string shoes = "Sneakers";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (dayTime == "Afternoon")
            {

                if (degrees >= 10 && degrees <= 18)
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else
                {
                    string outfit = "Swim Suit";
                    string shoes = "Barefoot";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (dayTime == "Evening")
            {
                string outfit = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }

        }
    }
}

