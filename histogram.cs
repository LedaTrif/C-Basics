using System;

namespace E03Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //total count
            
         
            int diapason1 = 0; // numbers count in diapason 1 (num<200)
            int diapason2 = 0; //num>=200 && num<400
            int diapason3 = 0;
            int diapason4 = 0;
            int diapason5 = 0;
            

            //x from y =%? ---> x/y*100
            for (int i = 0; i <n; i++)
            {
                int num= int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    diapason1++;
                    
                }

               else if (num>=200 && num<400)
                {
                    diapason2++;
                   

                }
      
                else if (num>=400 && num<600)
                {
                    diapason3++;
                    

                }
                
                else if (num >= 600 && num < 800)
                {
                    diapason4++;
                    
                }
    
               else if (num>=800)
                {
                    diapason5++;
                    

                }
    

            }

            //x/y*100

            double p1 = ((double)diapason1/n) * 100;
            double p2 = ((double)diapason2/ n) *100;
            double p3 = ((double)diapason3 / n) *100;
            double p4 = ((double)diapason4 / n) *100;
            double p5 = ((double)diapason5 / n) *100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}

