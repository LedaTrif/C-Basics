using System;

namespace ME04CarsToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double rentPrice = 0.00;



        if (budget<=100)
                           
        {
          string clasS = "Economy class";

             switch (season)
                            {
                                
                                case "Summer":
                                    
                                    rentPrice = budget * 0.35;
                                    string typeS = "Cabrio";

                                    Console.WriteLine($"{clasS}");
                                    Console.WriteLine($"{typeS} - {rentPrice:F2}");
                                    break;

                                case "Winter":
                                    
                                    rentPrice = budget * 0.65;
                                    string typeW = "Jeep";

                                    Console.WriteLine($"{clasS}");
                                    Console.WriteLine($"{typeW} - {rentPrice:F2}");
                                    break;
                            }
          }
           else if(budget>100 && budget<=500)
           {
                            string clasS = "Compact class";
                            switch (season)
                            {

                                case "Summer":

                                    rentPrice = budget * 0.45;
                                    string typeS = "Cabrio";

                                    Console.WriteLine($"{clasS}");
                                    Console.WriteLine($"{typeS} - {rentPrice:F2}");
                                    break;

                                case "Winter":

                                    rentPrice = budget * 0.80;
                                    string typeW = "Jeep";

                                    Console.WriteLine($"{clasS}");
                                    Console.WriteLine($"{typeW} - {rentPrice:F2}");
                                    break;
                            }
          }
          else if(budget>500)
           {
                            string clasS = "Luxury class";
                            string type = "Jeep";
                            rentPrice = budget * 0.9;
                            Console.WriteLine($"{clasS}");
                            Console.WriteLine($"{type} - {rentPrice:F2}");
            }
          }
          
    }
}

