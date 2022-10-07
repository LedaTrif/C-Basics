using System;

namespace E06FishDinnerPrice
{
    class Program
    {
        static void Main(string[] args)
        {

            double skumriaLvKg = double.Parse(Console.ReadLine());
            double zazaLvKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());


            double palamudLv = (skumriaLvKg + (skumriaLvKg * 0.60)) * palamudKg;
            double safridLv = (zazaLvKg + (zazaLvKg * 0.80)) * safridKg;
            double midiLv = midiKg * 7.50;

            double totalSumLv = palamudLv + safridLv + midiLv;
            string total = totalSumLv.ToString("F2");

            Console.WriteLine(total);
        }
    }
}

