using System;

namespace P05SchoolSuplies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int packPens = int.Parse(Console.ReadLine());
            int packMarkers = int.Parse(Console.ReadLine());
            int littersDetergent = int.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine());

            //Actions
            double pricePackPens = packPens * 5.80;
            double pricePackMarkers = packMarkers * 7.20;
            double priceLittersDetergent = littersDetergent * 1.20;
            double totalPrice = (pricePackPens + pricePackMarkers + priceLittersDetergent);
            double discountedPrice = totalPrice - (totalPrice * discountPercentage) / 100.00;

            //Output
            Console.WriteLine(discountedPrice);
        }
    }
}

