using System;

namespace _07PriceCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Turesday" || dayOfWeek == "Friday")
            {
                price = 12;
            }
            else if(dayOfWeek=="Wednesday" || dayOfWeek=="Thursday")
            {
                price= 14;
            }
            else
            {
                price = 16;
            }
            Console.WriteLine(price);
        }
    }
}

