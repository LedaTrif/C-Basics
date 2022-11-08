using System;

namespace E4TrainTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int judgesCnt = int.Parse(Console.ReadLine());

          
            double scoreTotalAll = 0;
          
            double averageScoreAll = 0;

            int scoresCnt = 0;

            double averageScorePerpresentation = 0;

            bool isFinish = true;
            double currentScorePresentattion;

            string command;
            while ((command=Console.ReadLine()) !="Finish")
            {
                currentScorePresentattion = 0;

                for (int i = 0; i < judgesCnt; i++)
                { 
                    double currentScore = double.Parse(Console.ReadLine());
                    currentScorePresentattion += currentScore;
                    averageScorePerpresentation = currentScorePresentattion / (double)judgesCnt;
                    scoresCnt++;
                }

                scoreTotalAll += currentScorePresentattion;
                averageScoreAll = scoreTotalAll/scoresCnt ;
                Console.WriteLine($"{command} - {averageScorePerpresentation:f2}.");
                
            }
    
            if (isFinish)
            {

                Console.WriteLine($"Student's final assessment is {averageScoreAll:f2}.");
            }
   

        }
    }
}

