using System;

namespace Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            

            double statuetki = rent * 0.7;
            double catering = statuetki * 0.85;
            double sound = catering / 2;

            double expensesTotal = rent*1.0 + statuetki + catering + sound;

            //Output Expenses total?

            Console.WriteLine($"{expensesTotal:F2}");
        }
    }
}

