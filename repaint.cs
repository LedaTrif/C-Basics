using System;

namespace P06PaintingRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int plasticM2 = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int detergentLiters = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());


            //Actions

        
            //calculate total without extras
            double pricePlasticNeeded = (plasticM2 + 2) * 1.50;
            double pricePaint = (paintLiters + (paintLiters*0.10)) * 14.50;
            double priceDetergentLiters = detergentLiters * 5.00;
            double bags = 0.40;
            double totalMaterials = pricePlasticNeeded + pricePaint + priceDetergentLiters + bags;
            double priceWork = (totalMaterials * 0.30) * hoursWork;

          
            double totalPrice = totalMaterials + priceWork;


            //Output

            Console.WriteLine($"{totalPrice}");


        }
    }
}

