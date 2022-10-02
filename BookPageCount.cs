using System;

namespace P04BookPages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inut
            int pageCount = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());


            //Actions
            int hoursNeeded = pageCount / pagesPerHour;
            int hoursPerDay = hoursNeeded / daysCount;

            //Output
            Console.WriteLine(hoursPerDay);
        }
    }
}

