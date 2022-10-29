using System;

namespace _08Graduation
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();


            int clas = 1;
            double allGrades = 0;
            double badGrades = 0;

            while (clas <=12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade >= 4)
                {
                   clas++;
                   allGrades+=currentGrade;

                }
                else 
                {
                    badGrades++;
                    if (badGrades>1)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas} grade");
                        return;
                    }
                    
                }
            }

            double averageGrade = allGrades / 12;

            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");

        }
    }
}

