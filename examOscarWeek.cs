using System;

namespace I03Oscars2
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string salonType = Console.ReadLine();
            int ticketsSold = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double income = 0;


            switch(movie)
            {
                case "A Star Is Born":
                    switch(salonType)
                    {
                        case "normal":
                            ticketPrice = 7.5;
                            break;
                        case "luxury":
                            ticketPrice = 10.5;
                            break;
                        case "ultra luxury":
                            ticketPrice = 13.5;
                            break;
                    }
                    break;
                case "Bohemian Rhapsody":
                    switch (salonType)
                    {
                        case "normal":
                            ticketPrice = 7.35;
                            break;
                        case "luxury":
                            ticketPrice = 9.45;
                            break;
                        case "ultra luxury":
                            ticketPrice = 12.75;
                            break;
                    }
                    break;
                case "Green Book":
                    switch (salonType)
                    {
                        case "normal":
                            ticketPrice = 8.15;
                            break;
                        case "luxury":
                            ticketPrice = 10.25;
                            break;
                        case "ultra luxury":
                            ticketPrice = 13.25;
                            break;
                    }
                    break;
                case "The Favourite":
                    switch (salonType)
                    {
                        case "normal":
                            ticketPrice = 8.75;
                            break;
                        case "luxury":
                            ticketPrice = 11.55;
                            break;
                        case "ultra luxury":
                            ticketPrice = 13.95;
                            break;
                    }
                    break;

            }

            income = (double)ticketsSold * ticketPrice;

            //Output income per movie input

            Console.WriteLine($"{movie} -> {income:f2} lv.");


        }
    }
}

