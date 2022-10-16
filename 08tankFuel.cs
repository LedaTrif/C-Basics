using System;

namespace _08FuelInTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());

     

            if (fuel=="Diesel")
            {
                string fuelName = "diesel";

                if(liters>=25)
                {
                    Console.WriteLine($"You have enough {fuelName}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuelName}!");
                }
            }
            else if(fuel=="Gasoline")
            {
                string fuelName = "gasoline";
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough {fuelName}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuelName}!");
                }
            }
            else if(fuel=="Gas")
            {
                string fuelName = "gas";
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough {fuelName}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuelName}!");
                }
            }
            else
            {
                Console.WriteLine($"Invalid fuel!");
            }

        }
    }
}

