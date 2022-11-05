using System;

namespace E07Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFlat = int.Parse(Console.ReadLine());
            int lenghtFlat = int.Parse(Console.ReadLine());
            int hightFlat= int.Parse(Console.ReadLine());

            int totalM3 = widthFlat * lenghtFlat * hightFlat; //V flat
            int totalBoxesM3 = 0;// V every box* boxesCnt 1m. x 1m. x 1m.---> =boxesCnt
            

            string command;

           while ((command=Console.ReadLine()) !="Done")
            {
                int boxesCnt= int.Parse(command);
                totalBoxesM3 += boxesCnt; // Един кашон е с точни размери:  1m. x 1m. x 1m.

                if(totalBoxesM3>=totalM3)
                {
                    Console.WriteLine($"No more free space! You need {totalBoxesM3-totalM3} Cubic meters more.");
                    break;
                }
 
            }
            if (command=="Done")
            {
                if (totalM3 > totalBoxesM3)
                {
                    Console.WriteLine($"{totalM3 - totalBoxesM3} Cubic meters left.");
                    return;
                }
                else
                {
                    return;
                }

            }
        }
    }
}

