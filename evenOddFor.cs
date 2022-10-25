using System;

namespace Е10OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {

           int n = int.Parse(Console.ReadLine());
           
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
               int num = int.Parse(Console.ReadLine());

               if(i%2==0)
                {
                    evenSum += num;
                }
                else if(i%2!=0)
                {
                    oddSum += num;
                }
              

            }
          if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }




        }
    }
}

