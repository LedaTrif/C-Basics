using System;

namespace E02EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input 2 numbers, a < b

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            


            for (int i = a; i <= b; i++)
            {
                string currentNum = i.ToString();
                int sumEvenDigits = 0;
                int sumOddDigits = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if(j % 2 == 0)
                    {
                        sumEvenDigits += currentDigit;
                    }
                    else
                    {
                        sumOddDigits += currentDigit;
                    }
                }
                if (sumEvenDigits == sumOddDigits)
                {
                    Console.Write($"{i} ");
                }
            }

            //Output all numbers between a and b, which sumEvenDigits=sumOddDigits
            //ex. 1034= 1odd+3odd=4 == 0even+4even==4 

            
        }
    }
}

