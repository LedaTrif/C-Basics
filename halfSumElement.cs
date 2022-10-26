using System;

namespace E02HalfSumElement
{
    class Program
    {
        static void Main(string[] args)

       {

            //Read n times number
            


            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;


            for (int i = 1; i <= n; i++)
            {
                
                int number = int.Parse(Console.ReadLine());

                sum += number;

                if(number>max)
                {
                    max = number;
                }
               
            }

            //sum of all other numbers-max
            sum -= max;

            if(sum==max)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum}");

            }
            else
            {
                int diff = Math.Abs(sum - max);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
