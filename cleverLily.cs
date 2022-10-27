using System;

namespace E04SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washmashinePrice= double.Parse(Console.ReadLine());
            int toyPrice= int.Parse(Console.ReadLine());

            double moneyFromToys = 0;
            double savingsPerEvenYear = 0;
            double savingsTotal = 0;

            //odd birthdays- age%2!=0 , collected toys= Math.Ceiling(age/2)
            //even birthdays- money, every next even birthday savings+10 BGN

            //1st bday-> toy=toyPrice.

           
         double birthdayCntOdd = Math.Ceiling(age/2.0);

         moneyFromToys = birthdayCntOdd * toyPrice;
 
         int birthdayCntEven = age / 2;

                for (int i = 0; i < birthdayCntEven; i++)
                {
                    savingsPerEvenYear = 10*i;
                    savingsPerEvenYear += 10;
                    savingsPerEvenYear--;//brother takse 1 BGN;
                    savingsTotal += savingsPerEvenYear;
                }
    

            //Output Yes! moneyLeft = ((savings- brother)+ toysSold)- washmashine Price
            // or No! moneyNeeded  :f2 = washmashine Price - ((savings-brother)+ toysSold)


            double moneyLeft = (savingsTotal + moneyFromToys) - washmashinePrice;
            double moneyNeeded = washmashinePrice - (savingsTotal + moneyFromToys);

            if (moneyLeft >= 0)
                
            {
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }

        }
    }
}

