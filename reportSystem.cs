using System;

namespace ME02ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //cash   odd=cash   --> moneycollectedCash+=payment---> moneycollectedTotal+=moneycolledctedCash;
            //card   even=card
            //cash   
            //card...


            //avrCash--->moneycollectedCash/paymentsCntCash;
            //avrCard--->moneycollectedCard/paymentsCntCard;

            //if product>100 BGN - cash not possible, only card (while product is >100  even,odd)
            //if product <10 BGN - card not possible, only cash (while product is >10 && <100 even, odd)
            // loops while command "End" || moneyCollected=moneyNeeded



            int moneyNeeded = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();


            int moneyCollectedCash = 0;
            int moneyCollectedCards = 0;
            

            int paymentsCntCash = 0;
            int paymentsCntCard = 0;
            int paymentsCnt = 0;

            double avrCash = 0;
            double avrCard = 0;

            while (input != "End")
            {

             paymentsCnt++;
                int payment = int.Parse(input);

                if (paymentsCnt % 2 != 0 && payment <= 100)//cash only
                {
                    paymentsCntCash++;
                    moneyNeeded -= payment;
                    moneyCollectedCash += payment;
                    Console.WriteLine($"Product sold!");//cash collected
                }
                else if (paymentsCnt % 2 == 0 && payment >= 10)
                {
                    paymentsCntCard++;
                    moneyNeeded -= payment;
                    moneyCollectedCards += payment;
                    Console.WriteLine($"Product sold!");
                }
                else
                {
                    Console.WriteLine($"Error in transaction!");
                }

                if ( moneyNeeded<=0)
                            {
                                avrCash = 1.0* moneyCollectedCash / paymentsCntCash;
                                Console.WriteLine($"Average CS: {avrCash:f2}");
                                avrCard = 1.0*moneyCollectedCards / paymentsCntCard;
                                Console.WriteLine($"Average CC: {avrCard:f2}");
                    break;
                }

                input = Console.ReadLine();
                       
            }
            if (input == "End")
            {

                Console.WriteLine($"Failed to collect required money for charity.");

            }
        }
    }
}

