using System;

namespace _08SerieTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string serieName = Console.ReadLine();
            double serieDuration = double.Parse(Console.ReadLine());
            double minutesBreak = double.Parse(Console.ReadLine());

            double restTime = minutesBreak / 4;
            double lunchTime = minutesBreak / 8;
            double freeTime = minutesBreak-lunchTime-restTime;


            if (freeTime>=serieDuration)
            {
                double minutesLeft = freeTime - serieDuration;
                int minutesLeftInt = (int)Math.Ceiling(minutesLeft);
                    Console.WriteLine($"You have enough time to watch {serieName} " +
                    $"and left with {minutesLeftInt} minutes free time.");
            }
            else
            {
                double minutesLeft = serieDuration - freeTime;
                int minutesLeftInt = (int)Math.Ceiling(minutesLeft);
                Console.WriteLine($"You don't have enough time to watch {serieName}, " +
                    $"you need {minutesLeftInt} more minutes.");
            }
        }
    }
}

