using System;


namespace MoreExercisesWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergent = int.Parse(Console.ReadLine())*750;// number of detergent bottles*750 ml per bottle

            
            int platesCnt = 0;
            int potsCnt = 0;
            int washCnt = 0;
            double detergentUsedPlates = 0;
            double detergentUsedPots = 0;
            double detergentUsedTotal = 0;
            double detergentLeft = 0;
         

            string command;

            while ((command= Console.ReadLine()) !="End")
            {
                int dishesCnt = int.Parse(command);
                washCnt++;
          

                if (washCnt % 3 != 0)        // 1st and 2nd wash---> all plates
                {
                    platesCnt += dishesCnt;
                    
                    detergentUsedPlates = dishesCnt * 5;//5 ml per plate needed
                    detergentUsedTotal += detergentUsedPlates;
            

                }
                else   //every 3rd wash---> all pots

                {
                    potsCnt += dishesCnt;
                   
                    detergentUsedPots = dishesCnt * 15;// 15 ml needed per pot
                    detergentUsedTotal += detergentUsedPots;
                    
                }

                
                detergentLeft = detergent - detergentUsedTotal;
               

                if (detergentLeft < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergentLeft)} ml. more necessary!");
                    return;

                }
  

            }

            if (command=="End")
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{platesCnt} dishes and {potsCnt} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentLeft} ml.");
                return;
            }


            Console.WriteLine($"Detergent was enough!");
            Console.WriteLine($"{platesCnt} dishes and {potsCnt} pots were washed.");
            Console.WriteLine($"Leftover detergent {detergentLeft} ml.");


        }
    }
}

