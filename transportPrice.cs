using System;

namespace E05TransportCost
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double taxiFee = 0.70;
            double taxiDay = 0.79;
            double taxiNight = 0.90;
            

            if (n<20 && dayTime=="day")
            {
                double price = taxiFee + taxiDay * n;
                Console.WriteLine($"{price:f2}");
            }
            else if (n<20 && dayTime=="night")
            {
                double price = taxiFee + taxiNight* n;
                Console.WriteLine($"{price:f2}");
            }
            else if(n<100)
            {
                if(dayTime == "night")
                {
                    double priceTaxi = taxiFee + taxiNight * n;
                    double priceBus = 0.09 * n;

                    if (priceTaxi < priceBus)
                    {
                        Console.WriteLine($"{priceTaxi:f2}");

                    }
                    else
                        Console.WriteLine($"{priceBus:f2}");
                }
                else if (dayTime == "day")
                {
                    double priceTaxi = taxiFee + taxiDay * n;
                    double priceBus = 0.09 * n;
                    if (priceTaxi<priceBus)
                    {
                        Console.WriteLine($"{priceTaxi:f2}");

                    }
                    else
                        Console.WriteLine($"{priceBus:f2}");
                }

            }
            else if(n>=100)
            {
                if (dayTime == "night")
                {
                    double priceTaxi = taxiFee + taxiNight * n;
                    double priceBus = 0.09 * n;
                    double priceTrain = 0.06 * n;

                    if (priceTaxi < priceBus && priceTaxi < priceTrain)
                    {
                        Console.WriteLine($"{priceTaxi:f2}");

                    }
                    else if (priceBus < priceTrain)
                    {

                        Console.WriteLine($"{priceBus:f2}");
                    }
                    else
                        Console.WriteLine($"{priceTrain:f2}");
                }
                else if (dayTime == "day")
                {
                    double priceTaxi = taxiFee + taxiDay * n;
                    double priceBus = 0.09 * n;
                    double priceTrain = 0.06 * n;

                    if (priceTaxi < priceBus && priceTaxi < priceTrain)
                    {
                        Console.WriteLine($"{priceTaxi:f2}");

                    }
                    else if (priceBus < priceTrain)
                    {

                        Console.WriteLine($"{priceBus:f2}");
                    }
                    else
                        Console.WriteLine($"{priceTrain:f2}");
                }
            }
        }
    }
}

