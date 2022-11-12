using System;

namespace _003Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates= Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double price = 0;

            switch(destination)
            {
                case "France":
                    if(dates=="21-23")
                    {
                        price = 30;
                    }
                    else if(dates=="24-27")
                    {
                        price = 35;
                    }
                    else if (dates == "28-31")
                    {
                        price = 40;
                    }
                    break;
                case "Italy":
                    if (dates == "21-23")
                    {
                        price = 28;
                    }
                    else if (dates == "24-27")
                    {
                        price = 32;
                    }
                    else if (dates == "28-31")
                    {
                        price = 39;
                    }
                    break;
                case "Germany":
                    if (dates == "21-23")
                    {
                        price = 32;
                    }
                    else if (dates == "24-27")
                    {
                        price = 37;
                    }
                    else if (dates == "28-31")
                    {
                        price = 43;
                    }
                    break;
            }

            double finalPrice = price * (nights * 1.0);
            Console.WriteLine($"Easter trip to {destination} : {finalPrice:F2} leva.");
        }
    }
}

