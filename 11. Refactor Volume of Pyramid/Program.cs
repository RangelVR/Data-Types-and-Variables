using System;
using System.Numerics;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double dul = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double sh = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double v = double.Parse(Console.ReadLine());

            Console.WriteLine($"Pyramid Volume: {((dul * sh * v) / 3):f2}");

        }
    }
}
