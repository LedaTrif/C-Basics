using System;

namespace I004EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //червено (red) оранжев(orange) син(blue) зелен(green)


            int paintedEggsTotal = int.Parse(Console.ReadLine());

            

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            

            int maxCount = int.MinValue;
            string maxColor = string.Empty;
            
            for (int i = 1; i <=paintedEggsTotal; i++)
            {
                string color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        redEggs++;
                        if (redEggs > maxCount)
                        {
                            maxCount = redEggs;
                            maxColor = color;
                        }
                        break;
                    case "orange":
                        orangeEggs++;
                        if (orangeEggs > maxCount)
                        {
                            maxCount = orangeEggs;
                            maxColor = color;
                        }
                        break;
                    case "blue":
                        blueEggs++;
                        if (blueEggs > maxCount)
                        {
                            maxCount = blueEggs;
                            maxColor = color;
                        }
                        ;
                        break;
                    case "green":
                        greenEggs++;
                        if (greenEggs > maxCount)
                        {
                            maxCount = greenEggs;
                            maxColor = color;
                        }
                        break;
                }
               
            }

           
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxCount} -> {maxColor}");

        }
    }
}

