using System;

namespace ForMoreExarcises
{
    class Program
    {
        static void Main(string[] args)
        {
            // ageIvancho = 18
            double moneyHeritated = double.Parse(Console.ReadLine());
            int yearOfDeath = int.Parse(Console.ReadLine());




            int currentAgeIvancho = 17;
            int yearsLifeLeft = yearOfDeath - 1799;
            //money spent even year=12000
            // money spent Odd year=12000+currentAge*50  
    
            double totalMoneySpentOdd = 0;
            double moneySpent1OddYear = 0;
            double evenYearsCnt = 0;

            


            for (int i = 0; i < yearsLifeLeft; i++)
            {

                if (i % 2 == 0)
                {
                    currentAgeIvancho++;

                }
                else if (i % 2 != 0)
                {
                    currentAgeIvancho++;
                    moneySpent1OddYear = (currentAgeIvancho * 50) + 12000;
                    totalMoneySpentOdd += moneySpent1OddYear;

                }

            }

            if (yearsLifeLeft % 2 == 0)
            {
                evenYearsCnt = Math.Floor((double)yearsLifeLeft / 2);
            }
            else if (yearsLifeLeft % 2 != 0)
            {
                evenYearsCnt = Math.Ceiling((double)yearsLifeLeft / 2);
            }

            double totalMoneySpentEven = evenYearsCnt * 12000;

            double totalMoneyLeft = moneyHeritated - (totalMoneySpentEven + totalMoneySpentOdd);
            if (totalMoneyLeft >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {Math.Abs(totalMoneyLeft):f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(totalMoneyLeft):f2} dollars to survive.");
            }
        }
    }
}

