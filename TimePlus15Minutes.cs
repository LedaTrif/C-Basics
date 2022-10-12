using System;

namespace _03TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes= int.Parse(Console.ReadLine()); ;

            int minutesCnt = minutes + 15;

          if(minutesCnt>60)
            {
                hours += 1;
                minutesCnt -= 60;
            }
          if(hours>24)
            {
                hours -= 24;
            }

            if (minutesCnt < 9)
            {
                Console.WriteLine($"{hours}:{minutesCnt:d2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutesCnt}");
            }

        }
    }
}

