using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeAvb = int.Parse(Console.ReadLine());
            int sceensCnt= int.Parse(Console.ReadLine());
            int timePerSceen= int.Parse(Console.ReadLine());


            double timePrep= timeAvb*0.15;
            double timeShootingDay = timePrep + 1.0*(timePerSceen * sceensCnt);

            if (timeAvb>=timeShootingDay)
            {
                double minutesleft = timeAvb - timeShootingDay;
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(minutesleft)} minutes left!");
            }
            else
            {
                double minutesMore = Math.Abs(timeShootingDay - timeAvb);
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(minutesMore)} minutes.");
            }


        }
    }
}

