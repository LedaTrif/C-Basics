using System;

namespace E05Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine())*100;

            int count = 0;

            // 2lv= 200 stotinki 
            // 1lv= 100 stotinki
            // 0.5= 50 stotinki
            // 0.2= 20 stotinki
            // 0.1= 10 stotinki
            // 0.05= 5 stotinki
            // 0.02= 2 stotinki
            // 0.01= 1 stotinka


            while(change>0)
            {
                if (change >= 200)
                {
                    change -= 200;
                }
                else if (change >= 100)
                {
                    change -= 100;
                }
                else if (change >= 50)
                {
                    change -= 50;
                }
                else if (change >= 20)
                {
                    change -= 20;
                }
                else if (change >= 10)
                {
                    change -= 10;
                }
                else if (change >= 5)
                {
                    change -= 5;
                }
                else if (change >= 2)
                {
                    change -= 2;
                }
                else if (change >= 1)
                {
                    change -= 1;
                }
                else
                {
                    break;
                }

                count++;
            }


            //Накрая печаташ само брояча.

            Console.WriteLine($"{count}");

        }
    }
}

