using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int metters = int.Parse(Console.ReadLine());
            double km = (double)(metters / 1000d);
            Console.WriteLine($"{km:f2}");
        }
    }
}
