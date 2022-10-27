using System;

namespace E06Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string actorName = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int judgesCnt = int.Parse(Console.ReadLine());


            double totalPoints = 0;
            double totalPointsPerJudges = 0;

            for (int i = 0; i < judgesCnt; i++)
            {

                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                //pointsPerActorPerJudge=(judgeName.lenght*judgePoints)/2

                int judgeNameLength = judgeName.Length;
                double pointsPerActorPerJudge= (judgeNameLength*judgePoints)/ 2;

                // total points= starting points + pointsPerActorPerJudge

                totalPointsPerJudges += pointsPerActorPerJudge;

                totalPoints = startingPoints + totalPointsPerJudges;

                //if totalpoints>=1250.5 program stops and write YES--> Actor nominated

                if (totalPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
                    return;
                }


            }
  
            //else NO: points missing = 1250.5 - totalPoints
 
                double pointsNeeded = 1250.5 - totalPoints;

                Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
            
        }
    }
}

