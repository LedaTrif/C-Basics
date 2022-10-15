using System;

namespace _07WorkingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            //Working hours: Mon-Sat 10-18 h


            if (hour >= 10 && hour < 18)
            {  switch(dayOfTheWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":

                        Console.WriteLine($"open");
                        break;
       
                    case "Sunday":
                   
                        Console.WriteLine($"closed");
                        break;

                }
               
            }

            else {

                Console.WriteLine($"closed");
            }



        }
    }
}

