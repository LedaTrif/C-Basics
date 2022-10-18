using System;
using System.Data;

namespace E08examOnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrivalH = int.Parse(Console.ReadLine());
            int arrivalM = int.Parse(Console.ReadLine());

            int examMinTotal = examH * 60 + examM;
            int arrivalMinTotal = arrivalH * 60 + arrivalM;

            int diff = examMinTotal - arrivalMinTotal;
           

            
            if (diff<0)
            {
                diff = Math.Abs(diff);
                int h = diff / 60;
                int m = diff % 60;
            
                if (h >= 1)
                {
                    Console.WriteLine($"Late");

                    Console.WriteLine($"{h}:{m:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"Late");
                    Console.WriteLine($"{m} minutes after the start");

                }

            }
            else if (diff > 30)
            {
                int h = diff / 60;
                int m = diff % 60;


                if (h >= 1)
                {

                    Console.WriteLine($"Early");
                    Console.WriteLine($"{h}:{m:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"Early");
                    Console.WriteLine($"{m} minutes before the start");
                }

            }
            else if (diff <= 30 && diff>=0)
            {
                int h = diff / 60;
                int m = diff % 60;


                if (h >= 1)
                {

                    Console.WriteLine($"On time");
                    Console.WriteLine($"{h}:{m:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"On time");
                    Console.WriteLine($"{m} minutes before the start");
                }
            }
            else if (diff == 0)
            {
                Console.WriteLine($"On time");
            }



        }
    }
}

