using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNum; i++)
            {
                int numberToProces = i;
                int sum = 0;
                while (numberToProces != 0)
                {
                    int currentDigit = numberToProces % 10;
                    numberToProces = numberToProces / 10;
                    sum += currentDigit;
                }
                bool isSpecial= sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
