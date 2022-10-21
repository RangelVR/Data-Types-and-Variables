using System;
using System.Numerics;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int numToProces = i;
                int sum = 0;

                while (numToProces != 0)
                {
                    int lastDigit = numToProces % 10;
                    numToProces = numToProces / 10;
                    sum += lastDigit;
                }
                bool isSpacialNum = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpacialNum}");
                //if (sum == 5 || sum == 7 || sum == 11)
                //{
                //    Console.WriteLine($"{i} -> True");
                //}
                //else
                //{
                //    Console.WriteLine($"{i} -> False");
                //}
            }
            
        }
    }
}
