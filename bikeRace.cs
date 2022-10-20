using System;

namespace ME2Velo
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();

            
            int totalPeople = juniors+seniors;
            double tax = 0;

            switch (route)
               
                {
               
                case "trail":
                    {
                       
                        tax = juniors * 5.5 + seniors * 7;

                    }
                    break;
                case "cross-country":
                    {
                        if (totalPeople >= 50)
                        {
                          tax = (juniors * 8 + seniors * 9.5)- ((juniors * 8 + seniors * 9.5))*0.25;
                        }
                        else
                        {
                            tax = juniors * 8 + seniors * 9.5;
                        }


                    }
                    break;
                case "downhill":
                    {
                         tax = juniors * 12.25 + seniors * 13.75;

                    }
                    break;
                case "road":
                    {
                         tax = juniors * 20 + seniors * 21.5;

                    }
                    break;

            }



        tax = tax- (tax*0.05);
            Console.WriteLine($"{tax:F2}");

        }
    }
}

