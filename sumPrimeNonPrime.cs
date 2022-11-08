using System;

namespace E03SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;


            string command;
            while ((command=Console.ReadLine()) !="stop")
            {
                int currentNumber = int.Parse(command);

                if(currentNumber<0)
                {
                    Console.WriteLine($"Number is negative.");
                    continue;
                }

                else if(currentNumber ==0 || currentNumber==1)
                {
                    sumNonPrime += currentNumber;
                    continue;
                }

                bool isPrime = true;
                for ( int div = 2;  div <=Math.Sqrt(currentNumber); div++)
                {
                    if (currentNumber%div == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime)
                {
                    sumPrime += currentNumber;
                }
                else
                {
                    sumNonPrime += currentNumber;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}

