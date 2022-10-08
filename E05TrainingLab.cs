using System;

namespace E05WorkPlacesUni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //Actions

            // the space between is 100 cm = (h-1m)
            double lenght = w * 100;
            double width = h * 100;

            //numer of work spaces for each side w and h
            int cols = ((int)width - 100) / 70;
            int rows = (int)lenght / 120;
            int seats = rows * cols - 3;


            //Output
            Console.WriteLine(seats);

        }
    }
}

