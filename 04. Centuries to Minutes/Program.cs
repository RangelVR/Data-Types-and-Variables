using System;
using System.Numerics;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int eyars = centuries * 100;
            int days = (int)(eyars * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {eyars} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
