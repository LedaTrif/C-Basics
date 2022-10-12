using System;
using System.Data;

namespace _06swimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input//

            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePer1MeterInSeconds = double.Parse(Console.ReadLine());

            //Actions//
            double timeIvanInSeconds = timePer1MeterInSeconds * distanceInMeters;
            double timeAddedSlow = distanceInMeters / 15;
            double additional = Math.Floor(timeAddedSlow) * 12.5;
            double totalTimeIvanInSeconds = timeIvanInSeconds + additional;


            //Output//

            if (totalTimeIvanInSeconds>=recordInSeconds)
            {
                double secondsLeft = totalTimeIvanInSeconds - recordInSeconds;
                    Console.WriteLine($"No, he failed! He was {secondsLeft:f2} seconds slower.");
            }

            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeIvanInSeconds:f2} seconds.");
            }


        }
    }
}

