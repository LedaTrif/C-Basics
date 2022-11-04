using System;

namespace E04Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

        
            double totalSteps = 0;


   
            while (command != "Going home")
            {
               double dailySteps = double.Parse(command);

                totalSteps += dailySteps;

                if (totalSteps >=10000)
                {
                    break;
                }

                command = Console.ReadLine();


            }
            if (command == "Going home")
            {
                double restSteps = double.Parse(Console.ReadLine());

                totalSteps += restSteps;
            }

                if (totalSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps-10000} steps over the goal!");

                }
                else
                {
                    Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");

                }

            }
            
        }
    }


