using System;

namespace E06NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

 

            if (symbol=='+')
            {
                double result = n1 + n2;
                if (result%2==0)
                {
                    string number = "even";
                    Console.WriteLine($"{n1} + {n2} = {result} - {number}");
                }
                else
                {
                    string number = "odd";

                    Console.WriteLine($"{n1} + {n2} = {result} - {number}");
                }

            }
            else if(symbol=='-')
            {
                double result = n1 - n2;
                if (result % 2 == 0)
                {
                    string number = "even";
                    Console.WriteLine($"{n1} - {n2} = {result} - {number}");
                }
                else
                {
                    string number = "odd";

                    Console.WriteLine($"{n1} - {n2} = {result} - {number}");
                }

            }
            else if(symbol=='*')
            {
                double result = n1 * n2;
                if (result % 2 == 0)
                {
                    string number = "even";
                    Console.WriteLine($"{n1} * {n2} = {result} - {number}");
                }
                else
                {
                    string number = "odd";

                    Console.WriteLine($"{n1} * {n2} = {result} - {number}");
                }

            }

            if (n2 != 0)
            {
                if (symbol == '/')
                {
                    double result = (double)n1 / (double)n2;

                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
                else if (symbol=='%')
                {
                    double result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }
            else
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
    


        }
    }
}

