using System;

namespace ME5Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;



            if (season == "Summer")
            {
                string location = "Alaska";

                if (budget <= 1000)
                {
                    string property = "Camp";

                    price = budget * 0.65;

                    Console.WriteLine($"{location} - {property} - {price:f2}");

                }
                else if (budget > 1000 && budget <= 3000)
                {
                    string property = "Hut";
                    price = budget * 0.8;
                    Console.WriteLine($"{location} - {property} - {price:f2}");
                }

                else if (budget > 3000)
                {
                    string property = "Hotel";
                    price = budget * 0.9;
                    Console.WriteLine($"{location} - {property} - {price:f2}");
                }
            }


            else if (season == "Winter")
            {
                string location = "Morocco";
                if (budget <= 1000)
                {
                    string property = "Camp";

                    price = budget * 0.45;

                    Console.WriteLine($"{location} - {property} - {price:f2}");

                }
                else if (budget > 1000 && budget <= 3000)
                {
                    string property = "Hut";
                    price = budget * 0.6;
                    Console.WriteLine($"{location} - {property} - {price:f2}");
                }

                else if (budget > 3000)
                {
                    string property = "Hotel";
                    price = budget * 0.9;
                    Console.WriteLine($"{location} - {property} - {price:f2}");
                }



            }
            


          



        }
    }
}

