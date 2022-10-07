using System;

namespace E07HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input meters for house hight, lenght and hight of the roof
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //Actions://

            //Calculate areas in sq.m.//
            //main square side 2 areas - area of the door//
            double mainSquareArea = (x * x) * 2;

            //main rectangle 2 areas - areas of 2 square windows//
            double mainRectangleArea = (x * y) * 2;

            //total area of the main part of the house in sq.m//
            double totalAreaMain = mainSquareArea + mainRectangleArea;

            //door and windows exclusion//
            double door = 1.2 * 2;
            double windows = (1.5 * 1.5) * 2;
            double excludeArea = door + windows;

            //roof triangle 2 areas//
            double roofTriangleArea = ((x * h) / 2) * 2;

            //roof rectangle 2 areas//
            double roofRectangleArea = (y * x) * 2;

            //total roof area//
            double totalAreaRoof = roofTriangleArea + roofRectangleArea;


            //paint calculation in lt if: 1 lt green is needed per 3.40 sq.m, 1lt red per 4.3 sq.m.//

            double ltMainArea = (totalAreaMain - excludeArea) / 3.4;
            double ltRoofArea = totalAreaRoof / 4.3;

            //round calculations to 2 decims after .//
            string ltGreenPaint = ltMainArea.ToString("F2");
            string ltRedPaint = ltRoofArea.ToString("F2");


            //Output show lt needed for green and red paint//
            Console.WriteLine(ltGreenPaint);
            Console.WriteLine(ltRedPaint);


        }
    }
}

