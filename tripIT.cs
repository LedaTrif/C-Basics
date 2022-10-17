using System;

namespace E05Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

       
            if (budget<=100)

            {
                string destination = "Bulgaria";
                if(season=="summer")
                {
                    double amountSpent = budget * 0.3;
                    string accommodation = "Camp";

                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{accommodation} - {amountSpent:F2}");
                }
                else if(season=="winter")
                {
                    {
                        double amountSpent = budget * 0.7;
                        string accommodation = "Hotel";

                        Console.WriteLine($"Somewhere in {destination}");
                        Console.WriteLine($"{accommodation} - {amountSpent:F2}");
                    }
                }
            }
            else if(budget<=1000)
            {
                string destination = "Balkans";
                if (season == "summer")
                {
                    double amountSpent = budget * 0.4;
                    string accommodation = "Camp";

                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{accommodation} - {amountSpent:F2}");
                }
                else if (season == "winter")
                {
                    {
                        double amountSpent = budget * 0.8;
                        string accommodation = "Hotel";

                        Console.WriteLine($"Somewhere in {destination}");
                        Console.WriteLine($"{accommodation} - {amountSpent:F2}");
                    }
                }
            }
            else if(budget>1000)
            {
                string destination = "Europe";
                double amountSpent = budget * 0.9;
                string accommodation = "Hotel";

                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{accommodation} - {amountSpent:F2}");

            }
        }
    }
}

