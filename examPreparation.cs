using System;

namespace E02Exam
{
    class Program
    {
        static void Main(string[] args)
        {

                int badScoresMax = int.Parse(Console.ReadLine());

            //bad score <=4

            double totalScores = 0;
            int problemsCnt = 0;
            int badScoreCnt = 0;
            string lastProblemName = "";

            bool isFailed = true;

            while (badScoreCnt < badScoresMax)
            {
                string problemName = Console.ReadLine();

                if (problemName=="Enough")
                {
                    isFailed = false;
                    break;
                }
                int currentScore = int.Parse(Console.ReadLine());
                if (currentScore<=4)
                {
                    badScoreCnt++;
                }

                totalScores += currentScore;
                problemsCnt++;
                lastProblemName = problemName;
            }
            if(isFailed)
            {
                Console.WriteLine($"You need a break, {badScoreCnt} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {totalScores / problemsCnt:f2}");
                Console.WriteLine($"Number of problems: {problemsCnt}");
                Console.WriteLine($"Last problem: {lastProblemName}");

            }

        }
    }
}

