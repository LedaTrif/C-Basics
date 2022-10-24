using System;

namespace ME6TruckSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmMonthly = double.Parse(Console.ReadLine());



            //kmMonthly*4 months= kmSeason
            //-10% taxes

            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if(kmMonthly<=5000)
                    {
                        double salaryGross = (kmMonthly * 0.75) * 4;
                        double salaryNet = salaryGross - (salaryGross * 0.10);
                        Console.WriteLine($"{salaryNet:f2}");
                    }
                    else if(kmMonthly>5000 && kmMonthly<=10000)
                    {
                        double salaryGross = (kmMonthly * 0.95) * 4;
                        double salaryNet = salaryGross - (salaryGross * 0.10);
                        Console.WriteLine($"{salaryNet:f2}");
                    }
                    else if(kmMonthly>10000 && kmMonthly<=20000)
                    {
                        double salaryGross = (kmMonthly * 1.45) * 4;
                        double salaryNet = salaryGross - (salaryGross * 0.10);
                        Console.WriteLine($"{salaryNet:f2}");
                    }

                    break;

                case "Summer":
                    if (kmMonthly <= 5000)
                    {
                        double salaryGross = (kmMonthly * 0.9) * 4;
                        double salaryNet = salaryGross - (salaryGross * 0.10);
                        Console.WriteLine($"{salaryNet:f2}");
                    }
                    else if (kmMonthly > 5000 && kmMonthly <= 10000)
                    {
                        double salaryGross = (kmMonthly * 1.1) * 4;
                        double salaryNet = salaryGross - (salaryGross * 0.10);
                        Console.WriteLine($"{salaryNet:f2}");
                    }
                    else if (kmMonthly > 10000 && kmMonthly <= 20000)
                    {
                        double salaryGross = (kmMonthly * 1.45) * 4;
                        double salaryNet = salaryGross - (salaryGross * 0.10);
                        Console.WriteLine($"{salaryNet:f2}");
                    }
                    break;
                case "Winter":
                    if (kmMonthly <= 5000)
                    {
                        double salaryGross = (kmMonthly * 1.05) * 4;
                        double salaryNet = salaryGross - (salaryGross * 0.10);
                        Console.WriteLine($"{salaryNet:f2}");
                    }
                    else if (kmMonthly > 5000 && kmMonthly <= 10000)
                    {
                        double salaryGross = (kmMonthly * 1.25) * 4;
                        double salaryNet = salaryGross - (salaryGross * 0.10);
                        Console.WriteLine($"{salaryNet:f2}");
                    }
                    else if (kmMonthly > 10000 && kmMonthly <= 20000)
                    {
                        double salaryGross = (kmMonthly * 1.45) * 4;
                        double salaryNet = salaryGross - (salaryGross * 0.10);
                        Console.WriteLine($"{salaryNet:f2}");
                    }
                    break;
                    
            }


            
        }
    }
}

