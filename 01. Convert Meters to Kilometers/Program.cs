using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal km = 0;
            km = meters / 1000m;
            Console.WriteLine($"{km:f2}");
        }
    }
}
