using System;

namespace E06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int lenghtCake= int.Parse(Console.ReadLine());
            int widthCake= int.Parse(Console.ReadLine());


            //1 piece= 1cm x 1 cm
            // S cake= lenghtCake x hightCake ---> num pieces total

            int totalPieces = lenghtCake * widthCake;
          

            string command;

            while ((command=Console.ReadLine()) !="STOP")
            {
                int piecesTaken = int.Parse(command);
                totalPieces -= piecesTaken;
                if (totalPieces<0)
                {

                    break;
                }
                
            }
            if (totalPieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
                
            }
            else
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
            

        }
    }
}

