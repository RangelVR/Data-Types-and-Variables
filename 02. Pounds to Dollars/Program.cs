using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());
            decimal usDollars = (decimal)britishPounds * 1.31m;
            Console.WriteLine($"{usDollars:f3}");
        }
    }
}
