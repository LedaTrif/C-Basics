using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination!="End")
            {
                double budget= double.Parse(Console.ReadLine());
                double savedMoney = double.Parse(Console.ReadLine());
                while (savedMoney<budget)
                {
                    double currentMoney= double.Parse(Console.ReadLine());

                    savedMoney += currentMoney;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();//write next destination and start while again
            }
        }
    }
}

