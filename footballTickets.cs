using System;

namespace ME1Match
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double transport = 0;
           

            switch (category)
            {
                case "VIP":
                    {
                        double ticketPrice = 499.99;

                        if (people <= 4)
                        { 
                            transport = budget * 0.75;
                        }
                        else if(people>=5 && people<=9)
                        {
                            transport = budget * 0.6;
                        }
                        else if(people>=10&&people<=24)
                        {
                            transport = budget * 0.5;
                        }
                        else if (people >= 25 && people <= 49)
                        {
                            transport = budget * 0.4;
                        }
                        else if (people >= 50)
                        {
                            transport = budget * 0.25;
                        }


                        double footbalPrice = people * ticketPrice + transport;
                        if(budget>=footbalPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget-footbalPrice):f2} leva left.");
                        }
                        else if(footbalPrice>budget)
                                {
                            Console.WriteLine($"Not enough money! You need {(footbalPrice - budget):f2} leva.");
                        }


                    }
                    break;
                case "Normal":
                    {
                        double ticketPrice = 249.99;

                        if (people <= 4)
                        {
                            transport = budget * 0.75;
                        }
                        else if (people >= 5 && people <= 9)
                        {
                            transport = budget * 0.6;
                        }
                        else if (people >= 10 && people <= 24)
                        {
                            transport = budget * 0.5;
                        }
                        else if (people >= 25 && people <= 49)
                        {
                            transport = budget * 0.4;
                        }
                        else if (people >= 50)
                        {
                            transport = budget * 0.25;
                        }


                        double footbalPrice = people * ticketPrice + transport;
                        if (budget >= footbalPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - footbalPrice):f2} leva left.");
                        }
                        else if (footbalPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(footbalPrice - budget):f2} leva.");
                        }


                    }
                    break;


            }
            
        }
    }
}

