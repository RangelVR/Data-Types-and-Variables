using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            Console.WriteLine($"{first}{second}{third}");
            
            //char ch1 = char.Parse(Console.ReadLine());
            //char ch2 = char.Parse(Console.ReadLine());
            //char ch3 = char.Parse(Console.ReadLine());

            //string word = string.Empty;

            //Console.WriteLine(word + ch1 + ch2 + ch3);
            
        }
    }
}
