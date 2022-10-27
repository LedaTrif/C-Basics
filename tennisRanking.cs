using System;

namespace E08TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournirsParticipated = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            
            int pointsGained = 0;
            int totalPointsExclStartingPoints = 0;
            int totalPoints = 0;
            int wins = 0;
            
            

            for (int i = 0; i < tournirsParticipated; i++)
            {
                string result = Console.ReadLine(); 

                if (result == "W")
                {
                    wins++;//брой победи
                    pointsGained = 2000;
                    totalPointsExclStartingPoints += pointsGained;
                }

                else if (result == "F")
                {
                    pointsGained = 1200;
                    totalPointsExclStartingPoints += pointsGained;
                }

                 else if(result=="SF")
                { 
                    pointsGained = 720;
                    totalPointsExclStartingPoints += pointsGained;
                       
                }
            }

            totalPoints = totalPointsExclStartingPoints + startingPoints;//брой точки след изиграните турнири
            double averagePointsPerTournir = totalPointsExclStartingPoints / tournirsParticipated;// средно колко точки печели за турнир
            double percentageWins = ((double)wins / tournirsParticipated)* 100;//процент спечелени турнири


            Console.WriteLine($"Final points: {totalPoints}"); 
            Console.WriteLine($"Average points: {Math.Floor(averagePointsPerTournir)}");
            Console.WriteLine($"{percentageWins:f2}%"); 


        }
    }
}

