using System;

namespace ME07SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string gender= Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nigths = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = "";

            if (gender=="boys")
            {
             
                switch (season)
                {
                    case "Winter":
                        price = nigths*students * 9.6;
                        sport = "Judo";
                        break;
                    case "Spring":
                        price = nigths*students * 7.2;
                         sport = "Tennis";
                        break;
                    case "Summer":
                        price = nigths*students * 15;
                        sport = "Football";
                        break;           
                }

                
            }
            else if (gender == "girls")
            {
                switch (season)
                {
                    case "Winter":
                        price = nigths*students * 9.6;
                        sport = "Gymnastics";
                        
                        break;
                    case "Spring":
                        price = nigths*students * 7.2;
                        sport = "Athletics";
                        break;
                    case "Summer":
                        price = nigths*students * 15;
                        sport = "Volleyball";
                        break;
                }
                
            }
            else if(gender=="mixed")
            {
                switch (season)
                {
                    case "Winter":
                        price = nigths*students * 10;
                        sport = "Ski";
                        break;
                    case "Spring":
                        price = nigths*students * 9.5;
                        sport = "Cycling";
                        break;
                    case "Summer":
                        price = nigths*students * 20;
                        sport = "Swimming";
                        break;
                }
            }
            if(students>=50)
            {
                price -= price * 0.5;
            }
              else if(students<50 && students>=20)
            {
                price -= price * 0.15;
            }
              else if (students < 20 && students >=10)
            {
                price -= price * 0.05;
            }

            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}

