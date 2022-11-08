using System;

namespace NestedLoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cnt = 1;

            bool isReady = false;

            //End condition will be never met

            for (int row = 1; row <= n; row++)
            {
                //for each row we need to pass rowNumber columns
                for (int col= 1; col <= row; col++)
                {
                    if (cnt > n)
                    {
                        isReady = true; //end single loop
                        break;
                    }


                    Console.Write($"{cnt} ");
                    cnt++;
                }

                if(isReady)
                {
                    break;//End the whole construction
                }
                Console.WriteLine();
            }
        }
    }
}

