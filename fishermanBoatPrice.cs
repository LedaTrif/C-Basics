using System;

namespace E04FishBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen= int.Parse(Console.ReadLine());





            if (fishermen <= 6)
            {
                if (season == "Spring")
                {
                    double boatPrice = 3000;
                    double discount = boatPrice * 0.10;
                    double discountedBoatPrice = boatPrice - discount;

                    if (fishermen % 2 == 0)
                    {
                        double totalBoatPrice = discountedBoatPrice - (discountedBoatPrice * 0.05);
                        if (budget >= totalBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - totalBoatPrice):F2} leva left.");
                        }
                        else if (totalBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(totalBoatPrice - budget):F2} leva.");
                        }
                    }
                    else
                    {
                        if (budget >= discountedBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                        }
                        else if (discountedBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                        }
                    }
                }
                else if (season == "Summer" || season == "Autumn")
                {
                    double boatPrice = 4200;
                    double discount = boatPrice * 0.10;
                    double discountedBoatPrice = boatPrice - discount;

                    if (fishermen % 2 == 0)
                    {
                        if (season != "Autumn")
                        {
                            double totalBoatPrice = discountedBoatPrice - (discountedBoatPrice * 0.05);
                            if (budget >= totalBoatPrice)
                            {
                                Console.WriteLine($"Yes! You have {(budget - totalBoatPrice):F2} leva left.");
                            }
                            else if (totalBoatPrice > budget)
                            {
                                Console.WriteLine($"Not enough money! You need {(totalBoatPrice - budget):F2} leva.");
                            }
                        }
                        else
                        {
                            
                            if (budget >= discountedBoatPrice)
                            {
                                Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                            }
                            else if (discountedBoatPrice > budget)
                            {
                                Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                            }
                        }
                    }
                    else
                    {
                        if (budget >= discountedBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                        }
                        else if (discountedBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                        }
                    }
                }
                else if (season == "Winter")
                {
                    double boatPrice = 2600;
                    double discount = boatPrice * 0.10;
                    double discountedBoatPrice = boatPrice - discount;

                    if (fishermen % 2 == 0)
                    {
                        double totalBoatPrice = discountedBoatPrice - (discountedBoatPrice * 0.05);
                        if (budget >= totalBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - totalBoatPrice):F2} leva left.");
                        }
                        else if (totalBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(totalBoatPrice - budget):F2} leva.");
                        }
                    }
                    else
                    {
                        if (budget >= discountedBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                        }
                        else if (discountedBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                        }
                    }
                }


            }
            else if (fishermen>=7 && fishermen <= 11)
            {
                if (season == "Spring")
                {
                    double boatPrice = 3000;
                    double discount = boatPrice * 0.15;
                    double discountedBoatPrice = boatPrice - discount;

                    if (fishermen % 2 == 0)
                    {
                        double totalBoatPrice = discountedBoatPrice - (discountedBoatPrice * 0.05);
                        if (budget >= totalBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - totalBoatPrice):F2} leva left.");
                        }
                        else if (totalBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(totalBoatPrice - budget):F2} leva.");
                        }
                    }
                    else
                    {
                        if (budget >= discountedBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                        }
                        else if (discountedBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                        }
                    }
                }
                else if (season == "Summer" || season == "Autumn")
                {
                    double boatPrice = 4200;
                    double discount = boatPrice * 0.15;
                    double discountedBoatPrice = boatPrice - discount;

                    if (fishermen % 2 == 0)
                 
                    {
                        if (season != "Autumn")
                        {
                            double totalBoatPrice = discountedBoatPrice - (discountedBoatPrice * 0.05);
                            if (budget >= totalBoatPrice)
                            {
                                Console.WriteLine($"Yes! You have {(budget - totalBoatPrice):F2} leva left.");
                            }
                            else if (totalBoatPrice > budget)
                            {
                                Console.WriteLine($"Not enough money! You need {(totalBoatPrice - budget):F2} leva.");
                            }
                        }
                        else
                        {

                            if (budget >= discountedBoatPrice)
                            {
                                Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                            }
                            else if (discountedBoatPrice > budget)
                            {
                                Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                            }
                        }
                    }
                    else
                    {
                        if (budget >= discountedBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                        }
                        else if (discountedBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                        }
                    }
                }
                else if (season == "Winter")
                {
                    double boatPrice = 2600;
                    double discount = boatPrice * 0.15;
                    double discountedBoatPrice = boatPrice - discount;

                    if (fishermen % 2 == 0)
                    {
                        double totalBoatPrice = discountedBoatPrice - (discountedBoatPrice * 0.05);
                        if (budget >= totalBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - totalBoatPrice):F2} leva left.");
                        }
                        else if (totalBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(totalBoatPrice - budget):F2} leva.");
                        }
                    }
                    else
                    {
                        if (budget >= discountedBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                        }
                        else if (discountedBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                        }
                    }
                }
            }
            else if (fishermen >= 12)
            {
                if (season == "Spring")
                {
                    double boatPrice = 3000;
                    double discount = boatPrice * 0.25;
                    double discountedBoatPrice = boatPrice - discount;

                    if (fishermen % 2 == 0)
                    {
                        double totalBoatPrice = discountedBoatPrice - (discountedBoatPrice * 0.05);
                        if (budget >= totalBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - totalBoatPrice):F2} leva left.");
                        }
                        else if (totalBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(totalBoatPrice - budget):F2} leva.");
                        }
                    }
                    else
                    {
                        if (budget >= discountedBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                        }
                        else if (discountedBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                        }
                    }
                }
                else if (season == "Summer" || season == "Autumn")
                {
                    double boatPrice = 4200;
                    double discount = boatPrice * 0.25;
                    double discountedBoatPrice = boatPrice - discount;

                    if (fishermen % 2 == 0)
                    {
                        if (season != "Autumn")
                        {
                            double totalBoatPrice = discountedBoatPrice - (discountedBoatPrice * 0.05);
                            if (budget >= totalBoatPrice)
                            {
                                Console.WriteLine($"Yes! You have {(budget - totalBoatPrice):F2} leva left.");
                            }
                            else if (totalBoatPrice > budget)
                            {
                                Console.WriteLine($"Not enough money! You need {(totalBoatPrice - budget):F2} leva.");
                            }
                        }
                        else
                        {

                            if (budget >= discountedBoatPrice)
                            {
                                Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                            }
                            else if (discountedBoatPrice > budget)
                            {
                                Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                            }
                        }
                    }
                    else
                    {
                        if (budget >= discountedBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                        }
                        else if (discountedBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                        }
                    }
                }
                else if (season == "Winter")
                {
                    double boatPrice = 2600;
                    double discount = boatPrice * 0.25;
                    double discountedBoatPrice = boatPrice - discount;

                    if (fishermen % 2 == 0)
                    {
                        double totalBoatPrice = discountedBoatPrice - (discountedBoatPrice * 0.05);
                        if (budget >= totalBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - totalBoatPrice):F2} leva left.");
                        }
                        else if (totalBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(totalBoatPrice - budget):F2} leva.");
                        }
                    }
                    else
                    {
                        if (budget >= discountedBoatPrice)
                        {
                            Console.WriteLine($"Yes! You have {(budget - discountedBoatPrice):F2} leva left.");
                        }
                        else if (discountedBoatPrice > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {(discountedBoatPrice - budget):F2} leva.");
                        }
                    }
                }
            }
         
               
            }


            

        }
    }


