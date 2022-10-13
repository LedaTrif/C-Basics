using System;

namespace TomSleepyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input//

            int daysOff = int.Parse(Console.ReadLine());

            //Actions//

            int playOff = daysOff * 127;
            int playWorkday = (365 - daysOff) * 63;

            int playTime = playOff + playWorkday;
            int norm = 30000;


            //Output//
            if (playTime>norm)
            {

                double timeToPlayMore = playTime-norm;
                double hours = timeToPlayMore / 60;
                double h = Math.Floor(hours);
                double m = timeToPlayMore % 60;

                if (m >= 60)
                {
                    h += 1;
                    m -= 60;
                }
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{h} hours and {m} minutes more for play");
            }

            else
            {
                double needMorePlayTime = norm - playTime;
                double hours = needMorePlayTime / 60;
                double h = Math.Floor(hours);
                double m = needMorePlayTime% 60;
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{h} hours and {m} minutes less for play");
            }
        }
    }
}


