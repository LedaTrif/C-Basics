using System;

namespace E09LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rigthSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num= int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                    rigthSum += num;
            }
            if(leftSum == rigthSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum-rigthSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}

