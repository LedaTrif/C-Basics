using System;

namespace E5SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int l = 1; l<=9; l++)
            {


                for (int k = 1; k <= 9; k++)
                {


                    for (int j = 1; j <= 9; j++)
                    {


                        for (int i = 1; i <= 9; i++)
                        {

                            bool isSpecial = n % l == 0 && n % k == 0 && n % j == 0 && n % i == 0;
                                if (isSpecial)
                                {
                                    Console.Write($"{l}{k}{j}{i} ");
                                }
                   
                        }
                    }
                }
            }
        }
    }
}

