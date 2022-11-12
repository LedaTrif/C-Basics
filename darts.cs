using System;

namespace I005Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if a player has win a leg?

            //starting points 301
            // sector 1-->Single--->points---->while 301-points=0: 
            // secotor 2-->Double--->points*2-----> (301-points*2)=0
            //sector 3--->Triple--->points*3----->(301-points*3)=0


            string name = Console.ReadLine();

            int leftPoints = 301;

            int successfulShots = 0;
            int failedShots = 0;
            

            while (leftPoints != 0)
            {
                string input = Console.ReadLine();

                if (input == "Retire")
                {
                    break;
                }

                int points = int.Parse(Console.ReadLine());

                if (input == "Single")
                {
                    if (points <= leftPoints)//success shots
                    {
                        leftPoints -= points;
                        successfulShots++;
                    }
                    else
                    {
                        failedShots++;
                    }
                }
                else if (input == "Double")
                {
                    if (points * 2 <= leftPoints)//success shots
                    {
                        leftPoints -= points * 2;
                        successfulShots++;
                    }
                    else
                    {
                        failedShots++;
                    }

                }
                else if (input == "Triple")
                {

                    if (points * 3 <= leftPoints)//success shots
                    {

                        leftPoints -= points * 3;
                        successfulShots++;
                    }
                    else
                    {
                        failedShots++;
                    }

                }

            }
            if (leftPoints == 0)
            {
                Console.WriteLine($"{name} won the leg with {successfulShots} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {failedShots} unsuccessful shots.");
            }
        }
    }
}

