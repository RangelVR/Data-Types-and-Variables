using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char leter = char.Parse(Console.ReadLine());
            if (leter >= 'a' && leter <= 'z')
            {
                Console.WriteLine("lower-case");
            }
            else if (leter >= 'A' && leter <= 'Z')
            {
                Console.WriteLine("upper-case");
            }

        }
    }
}
