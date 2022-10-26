using System;

namespace ForExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //show every number ending to 7 from 1 to 1000

            for (int i=1; i< 1000; i++)

            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}

