using System;

namespace _08FuelInTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string discountCard = Console.ReadLine();


            if(fuel=="Gasoline")
            {
                if (discountCard == "Yes")
                {
                    double price = (2.22 - 0.18) * quantity;
                    if (quantity >= 20 && quantity <= 25)
                    {
                        price -= price * 0.08;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity > 25)
                    {
                        price -= price * 0.1;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity < 20)
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if(discountCard=="No")
                {
                    double price = 2.22 * quantity;
                    if (quantity >= 20 && quantity <= 25)
                    {
                        price -= price * 0.08;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity > 25)
                    {
                        price -= price * 0.1;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity < 20)
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }

            }
            else if (fuel == "Gas")
            {
                if (discountCard == "Yes")
                {
                    double price = (0.93 - 0.08) * quantity;
                    if (quantity >= 20 && quantity <= 25)
                    {
                        price -= price * 0.08;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity > 25)
                    {
                        price -= price * 0.1;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity < 20)
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (discountCard == "No")
                {
                    double price = 0.93 * quantity;
                    if (quantity >= 20 && quantity <= 25)
                    {
                        price -= price * 0.08;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity > 25)
                    {
                        price -= price * 0.1;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity < 20)
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }

            }
            else if (fuel == "Diesel")
            {
                if (discountCard == "Yes")
                {
                    double price = (2.33 - 0.12) * quantity;
                    if (quantity >= 20 && quantity <= 25)
                    {
                        price -= price * 0.08;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity > 25)
                    {
                        price -= price * 0.1;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity < 20)
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (discountCard == "No")
                {
                    double price = 2.33 * quantity;
                    if (quantity >= 20 && quantity <= 25)
                    {
                        price -= price * 0.08;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (quantity > 25)
                    {
                        price -= price * 0.1;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if(quantity<20)
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                        
                }

            }
        }
    }
}

