using System;

namespace E05Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            //"Facebook" -> 150 лв.
            //"Instagram"-> 100 лв.
            //"Reddit"-> 50 лв.


            for (int i = 0; i < openTabs; i++)
            {
                string website = Console.ReadLine();

                if (website=="Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    return;
                }


            }
            
            if (salary>0)
            {
                Console.WriteLine($"{(int)salary}");
            }


        }
    }
}

